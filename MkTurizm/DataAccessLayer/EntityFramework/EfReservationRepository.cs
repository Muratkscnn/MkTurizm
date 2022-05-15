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
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
    {

        public List<Reservation> GetReservationWithBusService(int id)
        {
            using (var c=new MKContext())
            {
                return c.Reservations.Include(x => x.BusService).Where(x => x.BusServiceId == id).ToList();
            }
        }
    }
}
