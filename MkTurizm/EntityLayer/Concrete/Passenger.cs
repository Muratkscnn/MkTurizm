using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string PassengerTc { get; set; }
        public string PassengerTel { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}
