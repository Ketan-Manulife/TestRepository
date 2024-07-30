using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace WorkflowApp.Services.Helper
{
    public class BearerTokenHandler : DelegatingHandler
    {  

        private readonly VOAPIIdentityServerAPIClient _voIdentityapiClient;

        public BearerTokenHandler(VOAPIIdentityServerAPIClient voIdentityapiClient) : base()
        {
            _voIdentityapiClient = voIdentityapiClient;

        }
        public BearerTokenHandler(HttpMessageHandler innerHandler, VOAPIIdentityServerAPIClient
            voIdentityapiClient) : base(innerHandler)
        {
            _voIdentityapiClient = voIdentityapiClient;
        }
        private async Task<string> GetAccessToken()
        {
            string? accessToken = null;


            var authenticationString = "MemberServiceApiClient:manuLF2023temp";

            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authenticationString));

            _voIdentityapiClient.Client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authHeaderValue);


            var message = new HttpRequestMessage(HttpMethod.Post,
                $"VOIdentityServer/connect/token");


            var lstKeyEntries = new List<KeyValuePair<string, string>>();

            lstKeyEntries.Add(new KeyValuePair<string, string>("CWI-LoginName", "VOBatch"));

            lstKeyEntries.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));

            lstKeyEntries.Add(new KeyValuePair<string, string>("scope", "write:MemberAccess"));

            message.Content = new FormUrlEncodedContent(lstKeyEntries);

            message.Content.Headers.ContentType = new

             System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            try
            {
                var response = await _voIdentityapiClient.Client.SendAsync(message);

                if (response.IsSuccessStatusCode)

                {

                    var responseData = await response.Content.ReadAsStringAsync();

                    var jsonObject = JsonSerializer.Deserialize<JsonObject>(responseData);

                    var acessTokenData = jsonObject?.FirstOrDefault(src => src.Key == "access_token");

                    accessToken = acessTokenData?.Value?.ToString();

                }
            }
            catch (HttpRequestException)
            {

            }
            catch (Exception)
            {

            }
            return accessToken ?? "";

        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //Get the Bearer Token before sending http Request to VOAPI
            var bearerToken = await GetAccessToken();

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);

            return await base.SendAsync(request, cancellationToken);

        }


    }
}
