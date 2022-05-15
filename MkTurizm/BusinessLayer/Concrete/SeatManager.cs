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
    public class SeatManager : ISeatService
    {
        ISeatDal _seatDal;

        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }

        public void Add(Seat t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Seat t)
        {
            throw new NotImplementedException();
        }

        public Seat GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Seat> GetList()
        {
            return _seatDal.GetListAll();
        }

        public void Update(Seat t)
        {
            throw new NotImplementedException();
        }
    }
}
