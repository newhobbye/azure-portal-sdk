using azure_portal_lib.Helpers;
using RestSharp;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using azure_portal_lib.Models;
using azure_portal_lib.Models.Response;
using azure_portal_lib.Interfaces;
using System.Xml;
using System.Xml.Linq;

namespace azure_portal_lib.Services
{
    public class RestService : IRestService
    {
        private readonly RestClient _restClient;
        private readonly ConfigVariables _configVariables;
        private readonly IAuthService _authService;

        public RestService(ConfigVariables configVariables, IAuthService authService)
        {
            _configVariables = configVariables;
            _authService = authService;
            _restClient = new RestClient(_configVariables.BaseUrl);
        }

        public async Task<BaseResponse<DynamicResponse>> ExecuteRequest<DynamicResponse>(RestRequest request)
        {
            try
            {
                var auth = new AuthModel();
                auth = await _authService.Auth();

                request.AddHeader("Authorization", $"Bearer {auth.AccessToken}");
                var response = await _restClient.ExecuteAsync(request);

                var result = new BaseResponse<DynamicResponse>();

                if (response.StatusCode != HttpStatusCode.OK &&
                    response.StatusCode != HttpStatusCode.Created &&
                    response.StatusCode != HttpStatusCode.NoContent)
                {
                    result.Error = JsonSerializer.Deserialize<Error>(response.Content!)!;
                }
                else
                {
                    result.Value = JsonSerializer.Deserialize<DynamicResponse>(response.Content!)!;
                }

                result.HttpStatusCode = response.StatusCode.ToString();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<BaseResponse<DynamicResponse>> ExecuteRequestXML<DynamicResponse>(RestRequest request)
        {
            try
            {
                var auth = new AuthModel();
                auth = await _authService.Auth();

                request.AddHeader("Authorization", $"Bearer {auth.AccessToken}");
                var response = await _restClient.ExecuteAsync(request);

                var result = new BaseResponse<DynamicResponse>();

                if (response.StatusCode != HttpStatusCode.OK &&
                    response.StatusCode != HttpStatusCode.Created &&
                    response.StatusCode != HttpStatusCode.NoContent)
                {
                    result.Error = JsonSerializer.Deserialize<Error>(response.Content!)!;
                }
                else
                {
                    result.Value = JsonSerializer.Deserialize<DynamicResponse>(ConvertXmlToJson.Convert(response.Content!))!;
                }

                result.HttpStatusCode = response.StatusCode.ToString();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<BaseResponse<string>> ExecuteRequest(RestRequest request)
        {
            try
            {
                var auth = new AuthModel();
                auth = await _authService.Auth();

                request.AddHeader("Authorization", $"Bearer {auth.AccessToken}");
                var response = await _restClient.ExecuteAsync(request);

                var result = new BaseResponse<string>();

                if (response.StatusCode == HttpStatusCode.OK ||
                    response.StatusCode == HttpStatusCode.Accepted)
                {
                    return new BaseResponse<string>()
                    {
                        HttpStatusCode = response.StatusCode.ToString()
                    };
                }
                else
                {
                    result.Error = JsonSerializer.Deserialize<Error>(response.Content!)!;
                }

                result.HttpStatusCode = response.StatusCode.ToString();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
