using System.Threading.Tasks;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task AddAsync(User entity);
    }
}