using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Core.DTOs;
using WorkflowApp.Services.Interfaces;
using static WorkflowApp.Core.Domain.AppConstant;

namespace WorkflowApp.Services
{
    public partial class ContextService : IContextService
    {
        private readonly IHttpService _httpService;
        public ContextService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<CWIContextModel> CreateMemberContext(int pmemberid, string pDescription)
        {  
            var data = new
            {
                MemberId = pmemberid,
                Description = pDescription
            };
            return _httpService.HttpPost<CWIContextModel>(ApiUrl.CreateMemberContext, data).Result;
        }

        public async Task<CWIContextModel> GetMemberContext(string contextID)
        {
            return _httpService.HttpGet<CWIContextModel>(String.Format(ApiUrl.GetMemberContext, contextID)).Result;
        }

        public async Task<CommitContextModel> CommitMemberContext(string pcontextid, VoApiRequestHeader reqparam)
        {
            return _httpService.HttpPost<CommitContextModel>(String.Format(ApiUrl.CommitContext, pcontextid), null, reqparam).Result;
        }

    }
}
