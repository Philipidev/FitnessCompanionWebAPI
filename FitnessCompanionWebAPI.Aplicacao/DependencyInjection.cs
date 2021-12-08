﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FitnessCompanionWebAPI.Aplicacao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
