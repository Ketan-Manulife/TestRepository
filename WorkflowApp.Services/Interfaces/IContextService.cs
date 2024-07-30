using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Core.DTOs;
using static WorkflowApp.Core.Domain.AppConstant;

namespace WorkflowApp.Services.Interfaces
{
    public interface IContextService
    {
        Task<CWIContextModel> CreateMemberContext(int pmemberid, string pDescription);
        Task<CWIContextModel> GetMemberContext(string contextID);
        Task<CommitContextModel> CommitMemberContext(string pcontextid, VoApiRequestHeader reqparam);
    }
}
