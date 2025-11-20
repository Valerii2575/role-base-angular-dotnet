using RoleBase.Domain.Entities;

namespace RoleBase.Domain.Interfaces.Reporsitories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
