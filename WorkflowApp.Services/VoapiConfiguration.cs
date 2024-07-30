using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowApp.Services.Interfaces;

namespace WorkflowApp.Services
{
    public class VoapiConfiguration : IVoapiConfiguration
    {
        private readonly IConfiguration _Configure;
        public VoapiConfiguration(IConfiguration connfiguration)
        {
            _Configure = connfiguration;
        }
        public string VoapiBaseURL => _Configure["VoapiConfiguration:VoapiBaseURL"];

        public string TokenUrl => _Configure["VoapiConfiguration:TokenUrl"];

        public string ApiKey => _Configure["VoapiConfiguration:ApiKey"];

        public string Scope => _Configure["VoapiConfiguration:Scope"];

        public string ApiUserName => _Configure["VoapiConfiguration:ApiUserName"];

        public string ApiPassword => _Configure["VoapiConfiguration:ApiPassword"];
    }
}
