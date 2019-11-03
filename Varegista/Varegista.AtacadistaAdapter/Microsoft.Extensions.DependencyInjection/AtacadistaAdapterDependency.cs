using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Varegista.AtacadistaAdapter;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AtacadistaAdapterDependency
    {
        public static IServiceCollection AddAtacadistaAdapterDependency(this IServiceCollection services, string urlAtacadistaAdapter)
        {
            services.AddScoped<IAtacadistaAdapter, AtacadistaAdapter>();

            services.AddScoped(serviceProvider =>
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri(urlAtacadistaAdapter)
                };

                return RestService.For<IAtacadista>(httpClient);
            });

            return services;
        }
    }
}
