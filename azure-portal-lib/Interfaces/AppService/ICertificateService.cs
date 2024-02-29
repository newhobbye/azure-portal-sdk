using azure_portal_lib.Models.Request;
using azure_portal_lib.Models;
using System.Threading.Tasks;
using azure_portal_lib.Models.Response;

namespace azure_portal_lib.Interfaces.AppService
{
    public interface ICertificateService
    {
        Task<BaseResponse<string>> CreateOrUpdateCertificates(string nameCertificate, AddCertificateModel addCertificate);
        Task<BaseResponse<GetCertificatesResponse>> ListByResourceGroup();
        Task<BaseResponse<Value>> GetByCertifiedName(string certifiedName);
        Task<BaseResponse<string>> DeleteByCertifiedName(string certifiedName);
    }
}
