using DAL.Entities;
using Microsoft.EntityFrameworkCore;

public class TransportContext : DbContext
{
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Stop> Stops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TransportMonitoring;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>()
            .HasOne(v => v.Driver)
            .WithOne(d => d.Vehicle)
            .HasForeignKey<Vehicle>(v => v.DriverId);

        modelBuilder.Entity<Vehicle>()
            .HasOne(v => v.Route)
            .WithMany(r => r.Vehicles);

        modelBuilder.Entity<Route>()
            .HasMany(r => r.Stops)
            .WithOne(s => s.Route);

    }
}
