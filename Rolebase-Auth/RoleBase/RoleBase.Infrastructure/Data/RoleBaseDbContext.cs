using Microsoft.EntityFrameworkCore;
using RoleBase.Domain.Entities;

namespace RoleBase.Infrastructure.Data
{
    public class RoleBaseDbContext: DbContext
    {
        public RoleBaseDbContext(DbContextOptions<RoleBaseDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
