using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BusService
    {
        public int BusServiceId { get; set; }
        public int ToCityId { get; set; }
        public int? Station1Id { get; set; }
        public int? Station2Id { get; set; }
        public int FromCityId { get; set; }
        public City ToCity { get; set; }
        public City Station1 { get; set; }
        public City Station2 { get; set; }
        public City FromCity { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}
