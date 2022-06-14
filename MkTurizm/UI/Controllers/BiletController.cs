using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [AllowAnonymous]

    public class BiletController : Controller
    {
        UserManager<AppUser> _userManager;
        ReservationManager rm = new ReservationManager(new EfReservationRepository());

        public BiletController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

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
        public IActionResult DeleteTicket(int pnrNo)
        {
            var reservation=rm.GetReservationWithAllDetails(pnrNo);
            rm.Delete(reservation);
                return RedirectToAction("Index", "Home");
        }
        
        public async Task<IActionResult> MyTickets()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values=rm.GetReservationWithAllDetailsByUser(user.Id);
            if (values.Count>0)
            {
                return View(values);
            }
            return View();
        }
    }
}
