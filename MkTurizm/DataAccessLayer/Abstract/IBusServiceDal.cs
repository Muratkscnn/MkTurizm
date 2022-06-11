﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBusServiceDal :IGenericDal<BusService>
    {
        List<BusService> BusServiceList(int toCityId, int fromCityId);
        BusService BusServiceWithStationById(int id);
    }
}
