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
    public class PassengerManager : IPassengerService
    {
        IPassengerDal _passengerDal;

        public PassengerManager(IPassengerDal passengerDal)
        {
            _passengerDal = passengerDal;
        }

        public void Add(Passenger t)
        {
            _passengerDal.Add(t);
        }

        public void Delete(Passenger t)
        {
            _passengerDal.Delete(t);
        }

        public Passenger GetById(int id)
        {
            return _passengerDal.GetByID(id);
        }

        public Passenger GetLastPassenger()
        {
            return _passengerDal.GetListAll().LastOrDefault();
        }

        public List<Passenger> GetList()
        {
            return _passengerDal.GetListAll();
        }

        public void Update(Passenger t)
        {
            _passengerDal.Update(t);
        }
    }
}
