using Microsoft.EntityFrameworkCore;
using VRunWebApp.Models;

namespace VRunWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RaceCourse>Races { get; set; }

        public DbSet<RunningClub> RunningClubs { get; set; }

        public DbSet<Address> Address { get; set; }

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=False;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
