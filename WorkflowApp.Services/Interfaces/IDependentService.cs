using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Core.DTOs;

namespace WorkflowApp.Services.Interfaces
{
    public interface IDependentService
    {
        Task<List<DependentViewModel>> GetMemberDependents(int pMemberId);
        Task<string> AddMemberDependent(int pMemberId, string JsonData);

    }
}
