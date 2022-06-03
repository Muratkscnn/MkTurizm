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
    public class StationConfig : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasData(
                new Station { StationId=1,FromCity="Karabük", ToCity= "İstanbul", Station1="Kocaeli",Station2="Bolu",Price=300},
                new Station { StationId=2,FromCity="Gaziantep", ToCity= "İstanbul", Station1="Bolu",Station2="Adana",Price=500},
                new Station { StationId=3,FromCity="Bolu", ToCity= "İstanbul", Station1="",Station2="",Price=200},
                new Station { StationId=4,FromCity="Kocaeli", ToCity= "İstanbul", Station1="",Station2="",Price=100},
                new Station { StationId=5,FromCity="Adana", ToCity= "İstanbul", Station1="",Station2="",Price=400},
                new Station { StationId=6,FromCity="İstanbul", ToCity= "Karabük", Station1="",Station2="",Price=300},
                new Station { StationId=7,FromCity="Kocaeli", ToCity= "Karabük", Station1="",Station2="",Price=200},
                new Station { StationId=8,FromCity="Bolu", ToCity= "Karabük", Station1="",Station2="",Price=100},
                new Station { StationId=9,FromCity="Adana", ToCity= "Gaziantep", Station1="",Station2="",Price=200},
                new Station { StationId=10,FromCity="Bolu", ToCity= "Gaziantep", Station1="",Station2="",Price=400},
                new Station { StationId=11,FromCity="İstabul", ToCity= "Gaziantep", Station1="Adana",Station2="Bolu",Price=500}

                );
        }
    }
}
