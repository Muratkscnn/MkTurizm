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
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public List<Seat> Seats { get; set; }


    }
}
