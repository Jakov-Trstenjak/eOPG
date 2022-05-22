using eOPG.Services.Api.ServiceProviders;
using eOPG.Services.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Configuration
{
    public static class ServicesAppConfiguration
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddTransient<IFamilyFarmService, FamilyFarmService>();

            return services;
        }
    }
}
