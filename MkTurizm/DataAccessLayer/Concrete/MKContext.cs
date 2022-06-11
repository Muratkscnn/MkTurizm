using DataAccessLayer.Concrete.EntityConfig;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class MKContext : IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             //optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=MkTurizmDb;integrated security=true;");
             optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=MKTur;integrated security=true;");
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
            modelBuilder.Entity<Reservation>().HasKey(pc => new { pc.BusServiceId, pc.SeatId });
            modelBuilder.Entity<BusService>().HasOne(x => x.ToCity).WithMany(y => y.ToCity).HasForeignKey(z => z.ToCityId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<BusService>().HasOne(x => x.Station1).WithMany(y => y.Station1).HasForeignKey(z => z.Station1Id).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<BusService>().HasOne(x => x.Station2).WithMany(y => y.Station2).HasForeignKey(z => z.Station2Id).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<BusService>().HasOne(x => x.FromCity).WithMany(y => y.FromCity).HasForeignKey(z => z.FromCityId).OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CityConfig).Assembly);

        }


    }
}
