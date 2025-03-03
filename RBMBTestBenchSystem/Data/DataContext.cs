using Microsoft.EntityFrameworkCore;
using RBMBTestBenchSystem.Models;

namespace RBMBTestBenchSystem.Data
{
    public class DataContext : DbContext
    {
        //Reads the connection string
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        //This method is used when the context is created. It connects to the DB and chooses to connect to SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("SimulationsDB"));
        }
        public DbSet<Bearing> Bearings { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bearing>()
                .ToTable("Bearings");

            modelBuilder.Entity<Bearing>()
                .HasData(
                    new Bearing { BearingId = 1, Model = "alpha", MaxRotationSpeed = 2400},
                    new Bearing { BearingId = 2, Model = "beta", MaxRotationSpeed = 2865},
                    new Bearing { BearingId = 3, Model = "gamma", MaxRotationSpeed = 3100},
                    new Bearing { BearingId = 4, Model = "delta", MaxRotationSpeed = 3000},
                    new Bearing { BearingId = 5, Model = "epsilon", MaxRotationSpeed = 2750},
                    new Bearing { BearingId = 6, Model = "zeta", MaxRotationSpeed = 3300}
                );
        }
    }
}

