using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobilePhoneCatalog.Models;

namespace MobilePhoneCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using(var db = new MobilePhonesDBContext())
            {
                var mobile = new Phone
                {
                    ID = 1,
                    Name = "dede",
                    CpuModel = "ff"
                };
               
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IEnumerable<Phone> Get()
        {
            using(var _context = new MobilePhonesDBContext())
            {
                Phone phone = _context.Phones.Where(x => x.Name == "motorola").FirstOrDefault();
                phone.Name = "moto";
            //    phone.OperationSystem = "android";
              //  _context.Phones.Add(phone);
                _context.SaveChanges();



                return _context.Phones.ToList();
            }
//            return new List<Phone>();
        }
    }
}
