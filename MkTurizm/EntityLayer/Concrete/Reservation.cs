using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Reservation
    {
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int BusServiceId { get; set; }
        public int SeatNo { get; set; }
        public BusService BusService { get; set; }


    }
}
