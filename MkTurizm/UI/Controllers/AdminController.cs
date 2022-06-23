using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        CityManager cm = new CityManager(new EfCityRepository());
        BusServiceManager bm = new BusServiceManager(new EfBusServiceRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SeferAdd()
        {
            List<SelectListItem> cityValues = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CityName,
                                                   Value = x.CityId.ToString()
                                               }).ToList();
            ViewBag.cv = cityValues;
            return View();
        }
        [HttpPost]
        public IActionResult SeferAdd(BusServiceAddModel entity)
        {
            BusService model = new BusService()
            {
                ToCityId = entity.ToCityId,
                Station1Id = entity.Station1Id,
                Station2Id = entity.Station2Id,
                FromCityId = entity.FromCityId,
                Price = entity.Price,
                Status = true
            };
            string date = $"{entity.Date} {entity.Hour}";
            model.Date = DateTime.Parse(date);
            bm.Add(model);
            return RedirectToAction("SeferAdd");
        }
        public IActionResult SeferList()
        {
            var values=bm.BusServiceList();
            return View(values);
        }
    }
}
