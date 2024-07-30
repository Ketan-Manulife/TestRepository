using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Services.Helper
{
    public class VOAPIIdentityServerAPIClient
    {
        private readonly HttpClient _httpClient;

        internal HttpClient Client => _httpClient;

        public VOAPIIdentityServerAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(@"https://cdcwvigbmcat02.americas.manulife.net");
            _httpClient.Timeout = new TimeSpan(0, 0, 100);

        }
    }
}
