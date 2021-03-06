using Microsoft.Extensions.DependencyInjection;
using SquashMVC.Application.Interfaces;
using SquashMVC.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application
{
    public  static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); 
            return services;
        }

    }
}
