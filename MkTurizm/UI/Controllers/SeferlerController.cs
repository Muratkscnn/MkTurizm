using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    [AllowAnonymous]

    public class SeferlerController : Controller
    {
        UserManager<AppUser> _userManager;
        PassengerManager pm = new PassengerManager(new EfPassengerRepository());
        BusServiceManager bm = new BusServiceManager(new EfBusServiceRepository());
        ReservationManager rm = new ReservationManager(new EfReservationRepository());
        SeatManager sm = new SeatManager(new EfSeatRepository());

        public SeferlerController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult Index(BusService model)
        {
            int toCityId = model.ToCityId;
            int fromCityId = model.FromCityId;
            //var values = bm.GetList();
            var values = bm.BusServiceList(toCityId, fromCityId);
            return View(values);
        }

        public IActionResult BiletAl(int id)
        {
            List<SelectListItem> seatValues = (from x in sm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.SeatNo.ToString(),
                                                   Value = x.SeatId.ToString()
                                               }).ToList();
            ViewBag.sv = seatValues;
            ViewBag.id = id;
            ViewBag.station = bm.BusServiceWithStationById(id);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BiletAl(TicketAdd t)
        {
            Random rnd = new Random();
            int pnrno = rnd.Next();
            
            var p = new Passenger() { PassengerName = t.Passenger.PassengerName, PassengerTel = t.Passenger.PassengerTel, PassengerTc = t.Passenger.PassengerTc };
            pm.Add(p);
            var lastPassenger = pm.GetLastPassenger();
            var r = new Reservation() { BusServiceId = t.Reservation.BusServiceId, PassengerId = lastPassenger.PassengerId,SeatId=t.Reservation.Seat.SeatNo,PnrNo=pnrno};
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                r.AppUserId = user.Id;
            }
            rm.Add(r);
            return RedirectToAction("BiletBilgileri",r);
        }
        public IActionResult BiletBilgileri(Reservation r)
        {
            return View(r);
        }
    }
}
