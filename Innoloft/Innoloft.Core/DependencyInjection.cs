using AutoMapper;
using Innoloft.Core.Interfaces;
using Innoloft.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Innoloft.Core
{
    public static class DependencyInjection
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.ConfigureInjection();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        private static void ConfigureInjection(this IServiceCollection services)
        {
            //services.AddScoped<IJwtTokenService, JwtTokenService>();
        }
    }
}
