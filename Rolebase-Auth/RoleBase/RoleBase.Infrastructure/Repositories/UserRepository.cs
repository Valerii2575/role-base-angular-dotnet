using Microsoft.EntityFrameworkCore;
using RoleBase.Domain.Entities;
using RoleBase.Domain.Interfaces.Reporsitories;
using RoleBase.Infrastructure.Data;

namespace RoleBase.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(RoleBaseDbContext dbContext) : base(dbContext)
        {
        }
        public Task<User?> GetByEmailAsync(string email)
        {
            return _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
