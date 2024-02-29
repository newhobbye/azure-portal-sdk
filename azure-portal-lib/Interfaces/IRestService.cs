using azure_portal_lib.Models;
using RestSharp;
using System.Threading.Tasks;

namespace azure_portal_lib.Interfaces
{
    public interface IRestService
    {
        Task<BaseResponse<DynamicResponse>> ExecuteRequest<DynamicResponse>(RestRequest request);
        Task<BaseResponse<DynamicResponse>> ExecuteRequestXML<DynamicResponse>(RestRequest request);
        Task<BaseResponse<string>> ExecuteRequest(RestRequest request);
    }
}
