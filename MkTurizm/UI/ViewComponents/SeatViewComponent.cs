using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewComponents
{
    public class SeatViewComponent : ViewComponent
    {
        ReservationManager rm = new ReservationManager(new EfReservationRepository());
        public IViewComponentResult Invoke()
        {
            var id = Convert.ToInt32(RouteData.Values["id"]);
            return View(rm.GetReservationWithBusService(id));
        }
    }
}
