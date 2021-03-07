using System;
using DigiDesp.Drivers.Application;
using DigiDesp.Drivers.Application.Interfaces;
using DigiDesp.Drivers.Domain.Interfaces.Repositories;
using DigiDesp.Drivers.Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace DigiDesp.Drivers.CrossCutting.IoC
{
    public class BootStrap
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IDriverApplication, DriverApplication>();
            services.AddTransient<IDriverRepository, DriverRepository>();
        }
    }
}
