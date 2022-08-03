using System.Threading.Tasks;
using AulaRepositoryPattern.Core.Models;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepositoryBase<User> _repositoryBase;

        public UserRepository(IRepositoryBase<User> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task AddAsync(User entity)
        {
            await _repositoryBase.AddAsync(entity);
        }
    }
}