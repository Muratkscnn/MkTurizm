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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            this._cityDal = cityDal;
        }

        public void Add(City t)
        {
            _cityDal.Add(t);
        }

        public void Delete(City t)
        {
            _cityDal.Delete(t);
        }

        public City GetById(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> GetList()
        {
            return _cityDal.GetListAll();
        }

        public void Update(City t)
        {
            _cityDal.Update(t);
        }
    }
}
