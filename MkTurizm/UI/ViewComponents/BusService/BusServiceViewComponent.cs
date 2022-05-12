using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewComponents.BusService
{
    public class BusServiceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string tocity,string fromcity)
        {
            return View();
        }
    }
}
