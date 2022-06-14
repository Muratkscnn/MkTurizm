using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation t)
        {
            _reservationDal.Add(t);
        }

        public void Delete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> GetList()
        {
            return _reservationDal.GetListAll();
        }

        public Reservation GetReservationWithAllDetails(int Pnr)
        {
            return _reservationDal.GetReservationWithAllDetails(Pnr);

        }

        public List<Reservation> GetReservationWithAllDetailsByUser(int userId)
        {
            return _reservationDal.GetReservationWithAllDetailsByUser(userId);
        }

        public List<Reservation> GetReservationWithBusService(int id)
        {
            return _reservationDal.GetReservationWithBusService(id);
        }

        public void Update(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
