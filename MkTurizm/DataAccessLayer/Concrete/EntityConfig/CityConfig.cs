using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City() { CityId=1,CityName="İstanbul"},
                new City() { CityId=2,CityName="Bolu"},
                new City() { CityId=3,CityName="Kocaeli"},
                new City() { CityId=4,CityName="Karabük"},
                new City() { CityId=5,CityName="Adana"},
                new City() { CityId=6,CityName="Gaziantep"}
                );
        }
    }
}
