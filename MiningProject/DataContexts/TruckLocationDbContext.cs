using Microsoft.EntityFrameworkCore;
using MiningProject.Models;

namespace MiningProject.DataContexts
{
    public class TruckLocationDbContext : DbContext
    {
        public TruckLocationDbContext(DbContextOptions<TruckLocationDbContext> options) : base(options) { }

        public DbSet<History> Histories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Truck> Trucks { get; set; }


    }
}
