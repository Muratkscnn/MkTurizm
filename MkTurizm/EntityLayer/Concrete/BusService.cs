using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BusService
    {
        public int BusServiceId { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}
