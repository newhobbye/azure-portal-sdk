using azure_portal_lib.Helpers;
using azure_portal_lib.Helpers.Dependency;
using Microsoft.Extensions.DependencyInjection;

namespace azure_portal_tests
{
    public static class GetServiceInjection
    {
        public static T GetService<T>()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddAzureContainer(new ConfigVariables(
                "https://management.azure.com/",
                "YourClientId",
                "YourClientSecret",
                "YourSubcriptionId",
                "YourTenantId",
                "YourResourceGroupName"));

            var serviceProvider = serviceCollection.BuildServiceProvider();

            T? getService = serviceProvider.GetRequiredService<T>();

            return getService;
        }
    }
}
