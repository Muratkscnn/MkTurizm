using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetReservationWithBusService(int id);
        Reservation GetReservationWithAllDetails(int Pnr);
        List<Reservation> GetReservationWithAllDetailsByUser(int userId);

    }
}
