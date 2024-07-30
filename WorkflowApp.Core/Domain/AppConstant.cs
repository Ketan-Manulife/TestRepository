using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.Domain
{
    public class AppConstant
    {
        public static class ApiUrl
        {
            public static string GetClients = "/Clients";
            public static string GetDependents = "/member/{0}/Dependents"; // {0} = memberid
            public static string GetDependentById = "/member/{0}/Dependent/{1}"; // {0} = memberid


            public static string CreateMemberContext = "/context/member/create"; // 
            public static string GetMemberContext = "/context/{0}"; // {0} = memberid
            public static string CommitContext = "/context/{0}/commit"; // {0} = contextid
            public static string UpdateDependent = "/member/{0}/dependent/{1}"; // {0} = memberID, {1} = PersonID
            public static string AddDependent = "/member/{0}/dependent"; // {0} = memberID, {1} = PersonID
        }

    }
    public enum TransctionCategory
    {
        DependentUpdate = 0,
        MemberTransfer = 1

    }
}
