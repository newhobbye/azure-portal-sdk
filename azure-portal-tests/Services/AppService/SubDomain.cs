using azure_portal_lib.Interfaces.AppService;
using azure_portal_lib.Models;
using azure_portal_lib.Models.Request;
using System.Threading.Tasks;
using Xunit;

namespace azure_portal_tests.Services.AppService
{
    public class SubDomain
    {
        private readonly ISubDomainService _subDomainService;

        public SubDomain()
        {
            _subDomainService = GetServiceInjection.GetService<ISubDomainService>();
        }

        [Fact(DisplayName = "Listar hostNames pelo grupo de recursos")]
        public async Task ListByResourceGroup()
        {
            string nameApp = "apicybernightlyv2";
            var result = await _subDomainService.ListByResourceGroup(nameApp);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "Get analisar hostName")]
        public async Task GetAnalyzeCustomHostName()
        {
            string nameApp = "apicybernightlyv2";
            string hostName = "teste23.cyberangels.it";

            var result = await _subDomainService.GetAnalyzeCustomHostName(nameApp, hostName);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "pegar por hostName")]
        public async Task GetByHostNameBinding()
        {
            string nameApp = "apicybernightlyv2";
            string hostName = "teste.cyberangels.it";

            var result = await _subDomainService.GetByHostNameBinding(nameApp, hostName);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "deletar por hostName")]
        public async Task DeleteByHostNameBinding()
        {
            string nameApp = "apicybernightlyv2";
            string hostName = "teste.cyberangels.it";

            var result = await _subDomainService.DeleteByHostNameBinding(nameApp, hostName);

            Assert.NotNull(result);
        }

        [Fact(DisplayName = "Criar um hostName (sub-dominio)")]
        public async Task CreateOrUpdateHostNameBinding()
        {
            string nameApp = "apicybernightlyv2";
            string hostName = "teste.cyberangels.it";

            var domainModel = new AddSubDomainModel
            {
                Properties = new Property
                {
                    SiteName = "apicybernightlyv2",

                    //etapa com o certificado
                    Thumbprint = "5A0CB9FDE3051AB4B476071A9B706EFDB64E27F3",
                    SslState = "SniEnabled"
                }
            };

            var result = await _subDomainService.CreateOrUpdateHostNameBinding(nameApp, hostName, domainModel);

            Assert.NotNull(result);
        }
    }
}
