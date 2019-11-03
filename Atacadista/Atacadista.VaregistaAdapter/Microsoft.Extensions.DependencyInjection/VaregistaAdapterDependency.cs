using Atacadista.VaregistaAdapter;
using Atacadista.VaregistaAdapter.Interfaces;
using Refit;
using System;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class VaregistaAdapterDependency
    {
        public static IServiceCollection AddVaregistaAdapterDependency(this IServiceCollection services, string urlVaregistaAdapter)
        {
            services.AddScoped<IVaregistaAdapter, VaregistaAdapter>();

            services.AddScoped(serviceProvider =>
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri(urlVaregistaAdapter)
                };

                return RestService.For<IVaregista>(httpClient);
            });

            return services;
        }
    }
}
