using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBusServiceService : IGenericService<BusService>
    {
        List<BusService> BusServiceList(string tocity, string fromcity);
        BusService BusServiceWithStationById(int id);


    }
}
