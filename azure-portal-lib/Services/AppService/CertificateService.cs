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
    public class CertificateService : ICertificateService
    {
        private readonly IRestService _restService;
        private readonly ConfigVariables _configVariables;

        public CertificateService(IRestService restService, ConfigVariables configVariables)
        {
            _restService = restService;
            _configVariables = configVariables;
        }

        public async Task<BaseResponse<string>> CreateOrUpdateCertificates(string certifiedName, AddCertificateModel addCertificate)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/certificates");

            var request = new RestRequest($"{getCommonPath}/{certifiedName}",
                Method.Put);

            request.AddJsonBody(JsonSerializer.Serialize(addCertificate));

            request.AddQueryParameter("api-version", "2022-03-01");

            var result = await _restService.ExecuteRequest(request);

            return result;
        }

        public async Task<BaseResponse<GetCertificatesResponse>> ListByResourceGroup()
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/certificates");

            var request = new RestRequest(getCommonPath, Method.Get);

            request.AddQueryParameter("api-version", "2022-03-01");

            var result = await _restService.ExecuteRequest<GetCertificatesResponse>(request);

            return result;
        }

        public async Task<BaseResponse<Value>> GetByCertifiedName(string certifiedName)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/certificates");

            var request = new RestRequest($"{getCommonPath}/{certifiedName}", Method.Get);

            request.AddQueryParameter("api-version", "2022-03-01");

            var result = await _restService.ExecuteRequest<Value>(request);

            return result;
        }

        public async Task<BaseResponse<string>> DeleteByCertifiedName(string certifiedName)
        {
            string getCommonPath = ConstantVariables.CommonUrl(_configVariables.SubscriptionId,
                _configVariables.ResourceGroup, "Microsoft.Web/certificates");

            var request = new RestRequest($"{getCommonPath}/{certifiedName}", Method.Delete);

            request.AddQueryParameter("api-version", "2022-03-01");

            var result = await _restService.ExecuteRequest(request);

            return result;
        }
    }
}
