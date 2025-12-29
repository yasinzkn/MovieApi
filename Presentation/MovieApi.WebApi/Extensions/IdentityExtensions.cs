using Microsoft.AspNetCore.Identity;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;

namespace MovieApi.WebApi.Extensions
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddIdentitySevices (this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MovieContext>();

            return services;
        }
    }
}
