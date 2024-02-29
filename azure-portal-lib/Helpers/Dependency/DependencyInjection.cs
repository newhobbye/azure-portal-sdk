using azure_portal_lib.Interfaces;
using azure_portal_lib.Interfaces.AppService;
using azure_portal_lib.Services;
using azure_portal_lib.Services.AppService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;

namespace azure_portal_lib.Helpers.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAzureContainer(this IServiceCollection services,
            ConfigVariables? config = null,
            ServiceLifetime lifetime = ServiceLifetime.Scoped,
            ServiceLifetime restClientLifeTime = ServiceLifetime.Singleton)
        {
            if (services == null || config == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAdd(new ServiceDescriptor(typeof(IAuthService), typeof(AuthService), restClientLifeTime));
            services.TryAdd(new ServiceDescriptor(typeof(IRestService), typeof(RestService), restClientLifeTime));
            services.TryAdd(new ServiceDescriptor(typeof(ICertificateService), typeof(CertificateService), lifetime));
            services.TryAdd(new ServiceDescriptor(typeof(ISubDomainService), typeof(SubDomainService), lifetime));

            services.TryAddSingleton(config);

            return services;
        }
    }
}
