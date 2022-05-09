using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

    }
}
