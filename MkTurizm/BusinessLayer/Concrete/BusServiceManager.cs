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
    public class BusServiceManager : IBusServiceService
    {
        IBusServiceDal _busservice;

        public BusServiceManager(IBusServiceDal busservice)
        {
            _busservice = busservice;
        }

        public void Add(BusService t)
        {
            _busservice.Add(t);
        }

        public List<BusService> BusServiceList(int toCityId, int fromCityId)
        {
            return _busservice.BusServiceList(toCityId,fromCityId);
        }

        public List<BusService> BusServiceList()
        {
            return _busservice.BusServiceList();
        }

        public BusService BusServiceWithStationById(int id)
        {
            return _busservice.BusServiceWithStationById(id);
        }

        public void Delete(BusService t)
        {
            _busservice.Delete(t);
        }

        public BusService GetById(int id)
        {
           return _busservice.GetByID(id);
        }

        public List<BusService> GetList()
        {
            return _busservice.GetListAll();

        }

        public void Update(BusService t)
        {
            _busservice.Update(t);
        }
    }
}
