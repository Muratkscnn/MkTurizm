using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
