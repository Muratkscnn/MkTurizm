using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<BusService> ToCity { get; set; }
        public virtual ICollection<BusService> Station1 { get; set; }
        public virtual ICollection<BusService> Station2 { get; set; }
        public virtual ICollection<BusService> FromCity { get; set; }
    }
}
