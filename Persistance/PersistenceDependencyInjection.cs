using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CheAutoRemastered.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ICheAutoDbContext, CheAutoDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("CheAuto")));

            return services;
        }
    }
}
