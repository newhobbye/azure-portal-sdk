using azure_portal_lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace azure_portal_tests.Services
{
    public class Auth
    {
        private readonly IAuthService _authService;

        public Auth()
        {
            _authService = GetServiceInjection.GetService<IAuthService>();
        }

        [Fact(DisplayName = "Teste de autenticação azure")]
        public async Task AzureAuth()
        {
            var result = await _authService.Auth();

            Assert.NotNull(result);
        }
    }
}
