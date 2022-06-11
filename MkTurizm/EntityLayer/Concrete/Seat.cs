using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int SeatNo { get; set; }
        List<Reservation> reservations { get; set; }
    }
}
