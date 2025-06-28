using Ezyfit.Infrastructure.Data.Common;
using EzyFit.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace EzyFit.API.Extensions
{
    public static class EzyFitServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
