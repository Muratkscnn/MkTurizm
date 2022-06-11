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
                new BusService() { BusServiceId = 1, ToCityId=1,Station1Id=3,FromCityId=2,Price=100,  Date = DateTime.Parse("2022-05-12 20:00"), Status = true },
                new BusService() { BusServiceId = 2, ToCityId=1,Station1Id=2,Station2Id=3,FromCityId=3,Price=100,  Date = DateTime.Parse("2022-05-13 19:00"), Status = true },
                new BusService() { BusServiceId = 3, ToCityId=1,Station1Id=2,Station2Id=3,FromCityId=4,Price=200,  Date = DateTime.Parse("2022-05-13 18:00"), Status = true },
                new BusService() { BusServiceId = 4, ToCityId=1,Station1Id=2,Station2Id=3,FromCityId=5,Price=300,  Date = DateTime.Parse("2022-05-13 17:00"), Status = true },
                new BusService() { BusServiceId = 5, ToCityId=1,Station1Id=3,Station2Id=5,FromCityId=6,Price=400,  Date = DateTime.Parse("2022-05-12 16:00"), Status = true },
                new BusService() { BusServiceId = 6, ToCityId=1,Station1Id=4,Station2Id=5,FromCityId=6,Price=400,  Date = DateTime.Parse("2022-05-13 13:00"), Status = true },
                new BusService() { BusServiceId = 7, ToCityId=1,FromCityId=6,Price=500,  Date = DateTime.Parse("2022-05-12 14:00"), Status = true },
                new BusService() { BusServiceId = 8, ToCityId=1,FromCityId=2,Price=100,  Date = DateTime.Parse("2022-05-12 12:00"), Status = true },
                new BusService() { BusServiceId = 9,ToCityId=1,Station1Id=2,Station2Id=3,FromCityId=4,Price=400,  Date = DateTime.Parse("2022-05-12 14:00"), Status = true }
                );
        }
    }
}
