using Microsoft.EntityFrameworkCore;
using SecondProject.Models;

namespace DBC27API1.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Programme> Programmes { get; set; }
    }
}


