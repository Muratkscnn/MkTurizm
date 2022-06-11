using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]

    public class HomeController : Controller
    {

        CityManager cm = new CityManager(new EfCityRepository());
        public IActionResult Index()
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
    }

}
