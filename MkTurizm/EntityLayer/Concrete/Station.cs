using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Station
    {
        public int StationId { get; set; }
        public string ToCity { get; set; }
        public string Station1 { get; set; }
        public string Station2 { get; set; }
        public string FromCity { get; set; }
        public int Price { get; set; }
    }
}
