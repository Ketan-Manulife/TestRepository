using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Services.Interfaces
{
    public interface IVoapiConfiguration
    {
        string VoapiBaseURL { get; }
        string TokenUrl { get; }
        string ApiKey { get; }  
        string Scope { get; }
        string ApiUserName { get; }
        string ApiPassword { get; }
    }
}
