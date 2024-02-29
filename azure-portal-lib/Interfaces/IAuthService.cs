using azure_portal_lib.Models.Response;
using System.Threading.Tasks;

namespace azure_portal_lib.Interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> Auth();
    }
}
