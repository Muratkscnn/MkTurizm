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
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
    {
        public Reservation GetReservationWithAllDetails(int Pnr)
        {
            using (var c = new MKContext())
            {
                var values= c.Reservations.Include(x => x.BusService).ThenInclude(y => y.Station).Include(x => x.Passenger).Where(x => x.PnrNo == Pnr).FirstOrDefault();
                return values;
            }
        }

        public List<Reservation> GetReservationWithBusService(int id)
        {
            using (var c=new MKContext())
            {
                return c.Reservations.Include(x => x.BusService).Where(x => x.BusServiceId == id).ToList();
            }
        }
    }
}
