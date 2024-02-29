using azure_portal_lib.Models.Request;
using azure_portal_lib.Models.Response;
using azure_portal_lib.Models;
using System.Threading.Tasks;

namespace azure_portal_lib.Interfaces.AppService
{
    public interface ISubDomainService
    {
        Task<BaseResponse<AddSubDomainResponse>> CreateOrUpdateHostNameBinding(string nameApp, string hosting, AddSubDomainModel subDomainModel);
        Task<BaseResponse<GetDomainsResponse>> ListByResourceGroup(string nameApp);
        Task<BaseResponse<AddSubDomainResponse>> GetByHostNameBinding(string nameApp, string host);
        Task<BaseResponse<string>> DeleteByHostNameBinding(string nameApp, string host);
        Task<BaseResponse<CustomHostAnalysisResponse>> GetAnalyzeCustomHostName(string nameApp, string host);
    }
}
