using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        BusServiceManager bm = new BusServiceManager(new EfBusServiceRepository());

        CityManager cm = new CityManager(new EfCityRepository());
        public IActionResult Index()
        {
            List<SelectListItem> cityValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CityName,
                                                       Value = x.CityName.ToString()
                                                   }).ToList();
            ViewBag.cv = cityValues;
            return View();
        }
        [HttpPost]
        public IActionResult SeferBilgileri(Station s)
        {
            string toCity = s.ToCity;
            string fromCity = s.FromCity;
            //var values = bm.GetList();
            var values = bm.BusServiceList(toCity,fromCity);

            return View(values);
        }
        [HttpPost]
        public IActionResult TicketAdd(int id)
        {
            var values = bm.GetById(id);
            return View(values);
        }
    }

}
