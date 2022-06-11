using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class BiletController : Controller
    {
        ReservationManager rm = new ReservationManager(new EfReservationRepository());
        public IActionResult Index(string Pnr)
        {
            if (string.IsNullOrEmpty(Pnr))
            {
                return RedirectToAction("Index", "Home");
            }
            var value = rm.GetReservationWithAllDetails(int.Parse(Pnr));
            if (value != null)
            {
                return View(value);

            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult DeleteTicket(Reservation p)
        {
            rm.Delete(p);
                return RedirectToAction("Index", "Home");

        }
    }
}
