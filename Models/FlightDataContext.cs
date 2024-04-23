using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Models
{
    public class FlightDataContext : DbContext
    {
        public FlightDataContext(DbContextOptions<FlightDataContext> options) : base(options)
        {

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightTravelInfo>()
                .HasOne(f => f.Flight)
                .WithOne()
                .HasForeignKey<FlightTravelInfo>(f => f.FlightId);
        }

        public DbSet<FlightDetails> FlightDetailsModels { get; set; }
        public DbSet<FlightTravelInfo> FlightTravelInfos { get; set; }

        public static implicit operator FlightDataContext(FlightDetails v)
        {
            throw new NotImplementedException();
        }
    }

}
