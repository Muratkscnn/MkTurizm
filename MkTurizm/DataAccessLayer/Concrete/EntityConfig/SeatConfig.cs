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
    public class SeatConfig : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasData(

                new Seat() { SeatId=1,SeatNo=1},
                new Seat() { SeatId=2,SeatNo=2},
                new Seat() { SeatId=3,SeatNo=3},
                new Seat() { SeatId=4,SeatNo=4},
                new Seat() { SeatId=5,SeatNo=5},
                new Seat() { SeatId=6,SeatNo=6},
                new Seat() { SeatId=7,SeatNo=7},
                new Seat() { SeatId=8,SeatNo=8},
                new Seat() { SeatId=9,SeatNo=9},
                new Seat() { SeatId=10,SeatNo=10},
                new Seat() { SeatId=11,SeatNo=11},
                new Seat() { SeatId=12,SeatNo=12},
                new Seat() { SeatId=13,SeatNo=13},
                new Seat() { SeatId=14,SeatNo=14},
                new Seat() { SeatId=15,SeatNo=15},
                new Seat() { SeatId=16,SeatNo=16},
                new Seat() { SeatId=17,SeatNo=17},
                new Seat() { SeatId=18,SeatNo=18},
                new Seat() { SeatId=19,SeatNo=19},
                new Seat() { SeatId=20,SeatNo=20},
                new Seat() { SeatId=21,SeatNo=21},
                new Seat() { SeatId=22,SeatNo=22},
                new Seat() { SeatId=23,SeatNo=23},
                new Seat() { SeatId=24,SeatNo=24},
                new Seat() { SeatId=25,SeatNo=25},
                new Seat() { SeatId=26,SeatNo=26},
                new Seat() { SeatId=27,SeatNo=27},
                new Seat() { SeatId=28,SeatNo=28},
                new Seat() { SeatId=29,SeatNo=29},
                new Seat() { SeatId=30,SeatNo=30}
                );
        }
    }
}
