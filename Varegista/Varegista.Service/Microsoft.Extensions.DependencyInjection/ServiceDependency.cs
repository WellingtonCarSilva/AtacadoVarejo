using System;
using System.Collections.Generic;
using System.Text;
using Varegista.Service;
using Varegista.Service.Interfaces;

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
