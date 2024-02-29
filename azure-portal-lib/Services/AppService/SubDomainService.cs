using azure_portal_lib.Helpers;
using azure_portal_lib.Interfaces;
using azure_portal_lib.Interfaces.AppService;
using azure_portal_lib.Models;
using azure_portal_lib.Models.Request;
using azure_portal_lib.Models.Response;
using RestSharp;
using System.Text.Json;
using System.Threading.Tasks;

namespace azure_portal_lib.Services.AppService
{
    public class SubDomainService : ISubDomainService
    {
        private readonly IRestService _restService;
        private readonly ConfigVariables _configVariables;

        public SubDomainService(IRestService restService, ConfigVariables configVariables)
        {
            _restService = restService;
            _configVariables = configVariables;
        }

        public async Task<BaseResponse<AddSubDomainResponse>> CreateOrUpdateHostNameBinding(string nameApp, string host, AddSubDomainModel subDomainModel)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/sites");

            var request = new RestRequest($"{getCommonPath}/{nameApp}/hostNameBindings/{host}",
                Method.Put);

            request.AddQueryParameter("api-version", "2018-11-01");
            request.AddJsonBody(JsonSerializer.Serialize(subDomainModel));
            request.AddHeader("Content-Type", "application/json");

            var response = await _restService.ExecuteRequest<AddSubDomainResponse>(request);

            return response;
        }

        public async Task<BaseResponse<GetDomainsResponse>> ListByResourceGroup(string nameApp)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/sites");

            var request = new RestRequest($"{getCommonPath}/{nameApp}",
                Method.Get);

            request.AddQueryParameter("api-version", "2022-03-01");

            var response = await _restService.ExecuteRequest<GetDomainsResponse>(request);

            return response;
        }

        public async Task<BaseResponse<AddSubDomainResponse>> GetByHostNameBinding(string nameApp, string host)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/sites");

            var request = new RestRequest($"{getCommonPath}/{nameApp}/hostNameBindings/{host}",
                Method.Get);

            request.AddQueryParameter("api-version", "2018-11-01");

            var response = await _restService.ExecuteRequest<AddSubDomainResponse>(request);

            return response;
        }

        public async Task<BaseResponse<string>> DeleteByHostNameBinding(string nameApp, string host)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/sites");

            var request = new RestRequest($"{getCommonPath}/{nameApp}/hostNameBindings/{host}",
                Method.Delete);

            request.AddQueryParameter("api-version", "2022-03-01");

            var response = await _restService.ExecuteRequest(request);

            return response;
        }

        public async Task<BaseResponse<CustomHostAnalysisResponse>> GetAnalyzeCustomHostName(string nameApp, string host)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/sites");

            var request = new RestRequest($"{getCommonPath}/{nameApp}/analyzeCustomHostname",
                Method.Get);

            request.AddQueryParameter("api-version", "2018-11-01");
            request.AddQueryParameter("hostName", host);
            request.AddHeader("Accept", "application/xml");

            var response = await _restService.ExecuteRequestXML<CustomHostAnalysisResponse>(request);

            return response;
        }
    }
}
