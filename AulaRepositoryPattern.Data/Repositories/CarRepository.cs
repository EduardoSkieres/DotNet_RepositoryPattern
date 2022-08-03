using AulaRepositoryPattern.Data.Context;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(AppDbContext appContext) : base(appContext)
        {
            
        }
    }
}