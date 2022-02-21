using Microsoft.EntityFrameworkCore;
using Microservices_PlatformService.Models;
namespace Microservices_PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opt) : base(opt) //constructor
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }
        
        
    }
}