using DataAccessLayer.Concrete.EntityConfig;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    class MKContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             //optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=MkTurizmDb;integrated security=true;");
             optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=DenemeMKTur;integrated security=true;");
           // optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=MkTurizm;integrated security=true;");

        }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<BusService> BusServices { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasKey(pc => new { pc.BusServiceId, pc.SeatNo });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PassengerConfig).Assembly);

        }
      

    }
}
