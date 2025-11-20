using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoleBase.Domain.Interfaces.Reporsitories;
using RoleBase.Infrastructure.Repositories;

namespace RoleBase.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Data.RoleBaseDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }


    }
}
