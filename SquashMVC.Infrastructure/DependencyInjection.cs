using Microsoft.Extensions.DependencyInjection;
using SquashMVC.Application.Interfaces;
using SquashMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            return services;
        }
    }
}
