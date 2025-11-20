using RoleBase.Application.Interfaces;
using RoleBase.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RoleBase.Application.Extentions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Register application services here
             services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
