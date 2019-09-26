using Microsoft.Extensions.DependencyInjection;
using Parking.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
    {
        public static class ServiceCollectionExtensions
        {
            public static IServiceCollection AddApplication(this IServiceCollection services)
            {
           

                services.AddTransient<IParkingAppService, ParkingAppService>();

                return services;
            }

        }
    }

