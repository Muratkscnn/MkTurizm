using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class TicketAdd
    {
        public Passenger Passenger { get; set; }
        public Reservation Reservation { get; set; }
    }
}
