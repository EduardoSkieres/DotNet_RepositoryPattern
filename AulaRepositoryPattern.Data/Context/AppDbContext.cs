using AulaRepositoryPattern.Domain;
using Microsoft.EntityFrameworkCore;

namespace AulaRepositoryPattern.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Car> Carros { get; set; }
        public DbSet<User> Usuarios { get; set; }
    }
}