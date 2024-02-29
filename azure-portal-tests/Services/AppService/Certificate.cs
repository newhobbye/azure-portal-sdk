using azure_portal_lib.Interfaces.AppService;
using azure_portal_lib.Models.Request;
using System.Threading.Tasks;
using Xunit;

namespace azure_portal_tests.Services.AppService
{
    public class Certificate
    {
        private readonly ICertificateService _certificateService;

        public Certificate()
        {
            _certificateService = GetServiceInjection.GetService<ICertificateService>();
        }

        [Fact(DisplayName = "listar certificados pelo grupo de recursos")]
        public async Task ListByResourceGroup()
        {
            var result = await _certificateService.ListByResourceGroup();

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "pegar certificado por nome")]
        public async Task GetByCertifiedName()
        {
            string certifiedName = "VMmanager-WestEuropewebspace-221226122834";

            var result = await _certificateService.GetByCertifiedName(certifiedName);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "Deletar certificado por nome")]
        public async Task DeleteByCertifiedName()
        {
            string certifiedName = "teste.cyberangels.it-apicybernightlyv2";

            var result = await _certificateService.DeleteByCertifiedName(certifiedName);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "Adicionar certificado")]
        public async Task CreateOrUpdateCertificates()
        {
            //It is not possible to create a certificate without having a hostname of it
            string certifiedName = "teste.cyberangels.it-apicybernightlyv2";

            var certified = new AddCertificateModel
            {
                Location = "West Europe",
                Properties = new PropertiesCertificates
                {
                    ServerFarmId = "/subscriptions/95acfe4f-752e-45d4-a700-f3bcd32f32d5/resourceGroups/VMmanager/providers/Microsoft.Web/serverfarms/AppServices",
                    CanonicalName = "teste.cyberangels.it"
                }
            };

            var result = await _certificateService.CreateOrUpdateCertificates(certifiedName, certified);

            Assert.NotNull(result);
        }
    }
}
