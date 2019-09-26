using Microsoft.Extensions.DependencyInjection;
using Parking.Infr.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infr
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IParkingReadRepository, ParkingReadRepository>();
            return services;
        }

    }
}
