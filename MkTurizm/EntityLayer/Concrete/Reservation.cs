using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int? PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int BusServiceId { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public BusService BusService { get; set; }
        public int PnrNo { get; set; }
    }
}
