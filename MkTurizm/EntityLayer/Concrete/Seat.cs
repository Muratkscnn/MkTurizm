using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int BuServiceId { get; set; }
        public int SeatNo { get; set; }
        public bool SeatStatus { get; set; }
        public BusService BusService { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}
