using azure_portal_lib.Helpers;
using azure_portal_lib.Interfaces;
using azure_portal_lib.Models.Response;
using RestSharp;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace azure_portal_lib.Services
{
    public class AuthService : IAuthService
    {
        private readonly RestClient _restClient;
        private readonly ConfigVariables _configVariables;
        public AuthModel authModel;

        public AuthService(ConfigVariables configVariables)
        {
            _configVariables = configVariables;
            _restClient = new RestClient(ConstantVariables.BASE_AUTH_URL);
        }

        public async Task<AuthModel> Auth()
        {
            try
            {
                if (authModel == null || DateTime.Now > authModel.GeneratedToken.AddMilliseconds(Convert.ToInt32(authModel.ExpiresIn)))
                {
                    authModel = new AuthModel();

                    var request = new RestRequest($"{_configVariables.TenantId}{ConstantVariables.BASE_AUTH_RESOURCE}",
                        Method.Post);
                    request.AddParameter("grant_type", "client_credentials");
                    request.AddParameter("client_id", _configVariables.ClientId);
                    request.AddParameter("client_secret", _configVariables.ClientSecret);
                    request.AddParameter("resource", ConstantVariables.RESOURCE_AUTH);

                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

                    var response = await _restClient.ExecuteAsync(request);

                    if(response.StatusCode != HttpStatusCode.BadRequest)
                    {
                        authModel.GeneratedToken = DateTime.Now;
                    }

                    authModel = JsonSerializer.Deserialize<AuthModel>(response.Content!);

                    return authModel;
                }

                return authModel;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao se autenticar. {e.Message}");
            }
        }
    }
}
