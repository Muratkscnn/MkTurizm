using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBusServiceRepository : GenericRepository<BusService>, IBusServiceDal
    {
        public List<BusService> BusServiceList(string tocity, string fromcity)
        {
            using (var c=new MKContext())
            {
              return  c.BusServices.Include(x=>x.Station).Include(x => x.Reservation).ThenInclude(c => c.PassengerId).Where(x => x.Station.FromCity == fromcity && x.Station.ToCity == tocity).ToList();
            }
        }
    }
}
