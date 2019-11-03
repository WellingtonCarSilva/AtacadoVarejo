using Atacadista.Service;
using Atacadista.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceDependency
    {
        public static IServiceCollection AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();

            return services;
        }
    }
}
