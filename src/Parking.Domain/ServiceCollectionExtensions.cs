using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Context;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Dto.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ParkingDataContext, ParkingDataContext>();

            services.AddTransient<IParkingDomainService, ParkingDomainService>();

            services.AddTransient<IValidator<ParkingDto>, ParkingValidator>();

            return services;
        }

    }
}
