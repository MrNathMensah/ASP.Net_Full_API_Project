using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecondProject.Models;

namespace SecondProject.Entities
{
    public class ProjectEntities : IdentityDbContext<AppUser>
    {
        public ProjectEntities(DbContextOptions<ProjectEntities> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Programme> Programmes { get; set; }

        internal class Add
        {
            private Programme programme;

            public Add(Programme programme)
            {
                this.programme = programme;
            }
        }

        internal void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
