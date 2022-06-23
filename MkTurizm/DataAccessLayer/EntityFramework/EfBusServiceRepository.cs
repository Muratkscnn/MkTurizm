using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
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
        public List<BusService> BusServiceList(int toCityId, int fromCityId)
        {
            using (var c=new MKContext())
            {
              return  c.BusServices.Include(x=>x.ToCity).Include(y=>y.FromCity).Where(x => x.FromCityId== fromCityId && x.ToCityId == toCityId).ToList();
            }
        }
        public List<BusService> BusServiceList()
        {
            using (var c = new MKContext())
            {
                return c.BusServices.Include(x => x.ToCity).Include(y => y.FromCity).ToList();
            }
        }

        public BusService BusServiceWithStationById(int id)
        {
            using (var c=new MKContext())
            {
                return c.BusServices.Include(x => x.ToCity).Include(y => y.FromCity).
                    Include(z=>z.Station1).Include(s=>s.Station2).
                    Where(x => x.BusServiceId==id).FirstOrDefault();
            }
        }
    }
}
