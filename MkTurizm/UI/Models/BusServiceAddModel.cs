using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class BusServiceAddModel
    {
        public int BusServiceId { get; set; }
        public int ToCityId { get; set; }
        public int? Station1Id { get; set; }
        public int? Station2Id { get; set; }
        public int FromCityId { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }

    }
}
