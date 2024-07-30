using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.DTOs
{
    public class VoApiRequestHeader
    {
        public string Token { get; set; }
        public CWIRequestParameter CWIRequestParameter { get; set; }
    }

    public partial class CWIRequestParameter
    {
        public string CWIContextID { get; set; }
        public string CWIContextTag { get; set; }
        public string CWINoCommit { get; set; }
    }
}
