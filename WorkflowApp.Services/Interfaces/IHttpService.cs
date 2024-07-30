using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Core.DTOs;

namespace WorkflowApp.Services.Interfaces
{
    public interface IHttpService
    {
        public Task<T> HttpGet<T>(string uri) where T : class;
        public Task<T> HttpPost<T>(string uri, object dataToSend = null, VoApiRequestHeader header = null) where T : class;
    }
}
