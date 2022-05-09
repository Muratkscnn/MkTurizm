using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SeatManager : ISeatService

    {
        ISeatDal _seatDal;

        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }

        public void Add(Seat t)
        {
            _seatDal.Add(t);
        }

        public void Delete(Seat t)
        {
            _seatDal.Delete(t);
        }

        public Seat GetById(int id)
        {
           return _seatDal.GetByID(id);
        }

        public List<Seat> GetList()
        {
           return _seatDal.GetListAll();
        }

        public void Update(Seat t)
        {
            _seatDal.Update(t);
        }
    }
}
