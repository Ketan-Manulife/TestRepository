using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Core.Domain;
using WorkflowApp.Core.DTOs;
using WorkflowApp.Services.Interfaces;
using static WorkflowApp.Core.Domain.AppConstant;

namespace WorkflowApp.Services
{
    public class DependentService : IDependentService
    {
        private readonly IHttpService _httpService;
        private readonly IContextService _contextService;
        public DependentService(IHttpService httpService, IContextService contextService)
        {
            _httpService = httpService;
            _contextService = contextService;
        }
        public async Task<List<DependentViewModel>> GetMemberDependents(int pMemberId)
        {
            return  _httpService.HttpGet<List<DependentViewModel>>(string.Format(AppConstant.ApiUrl.GetDependents,pMemberId.ToString())).Result;
        }

        public async Task<string> AddMemberDependent(int pMemberId,string JsonData)
        {
            var model = JsonConvert.DeserializeObject<DependentBase>(JsonData);

            var Depaddmodel = JsonConvert.DeserializeObject<DependentRequestModel>(model.Data);

            // Create Member Context to add dependent
            var _context = _contextService.CreateMemberContext(model.MemberID, "Add dependent").Result;
            var reqpara = new VoApiRequestHeader
            {
                CWIRequestParameter = new CWIRequestParameter
                {
                    CWIContextID = _context.ContextId.ToString(),
                    CWIContextTag = _context.ContextTag,
                    CWINoCommit = "true"
                }
            };
            //Add member with the use of Context
            var adddep = _httpService.HttpPost<DependentViewModel>(String.Format(ApiUrl.AddDependent, model.MemberID.ToString()), Depaddmodel, reqpara);

            //Get new ContextTag from old Context ID

            _context = _contextService.GetMemberContext(reqpara.CWIRequestParameter.CWIContextID).Result;
            var reqpara1 = new VoApiRequestHeader
            {
                CWIRequestParameter = new CWIRequestParameter
                {
                    CWIContextID = _context.ContextId.ToString(),
                    CWIContextTag = _context.ContextTag
                }
            };

            var commitedcontext = _contextService.CommitMemberContext(_context.ContextId.ToString(), reqpara1);

            string retmessage = string.Empty;
            if (commitedcontext.Id > 0)
            {
                retmessage = "Dependent Updated Successfully";
            }
            else
            {
                retmessage = "error in Dependent Update";
            }
            return retmessage;

        }
       
    }
}
