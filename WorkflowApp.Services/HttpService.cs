using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using WorkflowApp.Core.DTOs;
using WorkflowApp.Services.Interfaces;

namespace WorkflowApp.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IVoapiConfiguration _voApiConfiguration;
        public HttpService(HttpClient httpClient, IVoapiConfiguration voApiConfiguration)
        {
            _httpClient = httpClient;
            _voApiConfiguration = voApiConfiguration;
        }
        public async Task<T> HttpGet<T>(string uri)
           where T : class
        {
            try
            {
                //SetRequestHeader(header);

                var result = await _httpClient.GetAsync($"{_voApiConfiguration.VoapiBaseURL}{uri}");
                if (!result.IsSuccessStatusCode)
                {
                    return null;
                }

                return await FromHttpResponseMessage<T>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> HttpPost<T>(string uri, object dataToSend = null, VoApiRequestHeader header = null)
           where T : class
        {
            try
            {
                SetRequestHeader(header);
                var content = ToJson(dataToSend ?? string.Empty);

                var result = await _httpClient.PostAsync($"{_voApiConfiguration.VoapiBaseURL}{uri}", content);
                if (!result.IsSuccessStatusCode)
                {
                    var exception = JsonSerializer.Deserialize<ErrorDetail>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    // _toastService.ShowToast($"Error : {exception.Message}", ToastLevel.Error);
                   // throw new Exception(exception.Message);

                    return null;
                }

                return await FromHttpResponseMessage<T>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> HttpPut<T>(string uri, object dataToSend = null, VoApiRequestHeader header = null)
           where T : class
        {
            SetRequestHeader(header);
            var content = ToJson(dataToSend);

            var result = await _httpClient.PutAsync($"{_voApiConfiguration.VoapiBaseURL}{uri}", content);
            if (!result.IsSuccessStatusCode)
            {
                //_toastService.ShowToast("Error", ToastLevel.Error);
                return null;
            }

            return await FromHttpResponseMessage<T>(result);
        }

        private async Task<T> FromHttpResponseMessage<T>(HttpResponseMessage result)
        {
            return JsonSerializer.Deserialize<T>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        private void SetRequestHeader(VoApiRequestHeader reqHeader)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Clear();
               // _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                if (reqHeader != null)
                {
                    
                  //  _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + reqHeader.Token ?? string.Empty);

                    if (reqHeader.CWIRequestParameter != null)
                    {
                        if (!string.IsNullOrEmpty(reqHeader.CWIRequestParameter.CWIContextID))
                        {
                            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("CWI-ContextId", reqHeader.CWIRequestParameter.CWIContextID ?? string.Empty);
                        }
                        if (!string.IsNullOrEmpty(reqHeader.CWIRequestParameter.CWIContextTag))
                        {
                            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("CWI-ContextTag", reqHeader.CWIRequestParameter.CWIContextTag ?? string.Empty);
                        }
                        if (!string.IsNullOrEmpty(reqHeader.CWIRequestParameter.CWINoCommit))
                        {
                            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("CWI-no-commit", reqHeader.CWIRequestParameter.CWINoCommit ?? string.Empty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private StringContent ToJson(object obj)
        {
            return new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
        }
    }
}
