using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityConfig
{
    public class BusServiceConfig : IEntityTypeConfiguration<BusService>
    {
        public void Configure(EntityTypeBuilder<BusService> builder)
        {
            builder.HasData(
                new BusService() { BusServiceId = 1, StationId = 1, Date = DateTime.Parse("2022-05-12 20:00"), Status = true },
                new BusService() { BusServiceId = 2, StationId = 2, Date = DateTime.Parse("2022-05-12 19:00"), Status = true },
                new BusService() { BusServiceId = 3, StationId = 3, Date = DateTime.Parse("2022-05-12 18:00"), Status = true },
                new BusService() { BusServiceId = 4, StationId = 4, Date = DateTime.Parse("2022-05-12 17:00"), Status = true },
                new BusService() { BusServiceId = 5, StationId = 5, Date = DateTime.Parse("2022-05-12 16:00"), Status = true },
                new BusService() { BusServiceId = 6, StationId = 6, Date = DateTime.Parse("2022-05-12 13:00"), Status = true },
                new BusService() { BusServiceId = 7, StationId = 7, Date = DateTime.Parse("2022-05-12 14:00"), Status = true },
                new BusService() { BusServiceId = 8, StationId = 8, Date = DateTime.Parse("2022-05-12 12:00"), Status = true },
                new BusService() { BusServiceId = 9, StationId = 9, Date = DateTime.Parse("2022-05-12 18:00"), Status = true },
                new BusService() { BusServiceId = 10, StationId = 10, Date = DateTime.Parse("2022-05-12 19:00"), Status = true },
                new BusService() { BusServiceId = 11, StationId = 11, Date = DateTime.Parse("2022-05-12 23:00"), Status = true },
                new BusService() { BusServiceId = 12, StationId = 2, Date = DateTime.Parse("2022-05-12 22:00"), Status = true },
                new BusService() { BusServiceId = 13, StationId = 3, Date = DateTime.Parse("2022-05-12 21:00"), Status = true },
                new BusService() { BusServiceId = 14, StationId = 1, Date = DateTime.Parse("2022-05-12 13:00"), Status = true },
                new BusService() { BusServiceId = 15, StationId = 2, Date = DateTime.Parse("2022-05-12 14:00"), Status = true }


                );
        }
    }
}
