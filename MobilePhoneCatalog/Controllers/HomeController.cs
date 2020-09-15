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
        public ViewResult GetAllPhones()
        {
            var _context = new MobilePhonesDBContext();
            var data = _context.Phones.ToList();
            return View(data);
        }

        public IEnumerable<PhoneModel> SyncPhones()
        {
            using (var _context = new MobilePhonesDBContext())
            {
                PhoneModel phoneModel = new PhoneModel
                {
                    Name = "Iphone XR",
                    Manufacturer = "Apple",
                    OperationSystem = "IOS",
                    Price = 1800,
                    ScreenRezolution = "1920x1200",
                    ScreenSize = 5.5,
                    Size = "170x68x12",
                    Storage = 256,
                    Weitht = 230
                };
                _context.Phones.Add(phoneModel);
                for (int i = 0; i < 3; i++)
                {
                    phoneModel = new PhoneModel
                    {
                        Name = "GOOGLE PIXEL",
                        Manufacturer = "Google",
                        OperationSystem = "Android",
                        Price = 2000,
                        ScreenRezolution = "1920x1200",
                        ScreenSize = 5.5,
                        Size = "170x68x12",
                        Storage = 256,
                        Weitht = 230
                    };
                    _context.Phones.Add(phoneModel);
                }
               
                _context.SaveChanges();
            }
            return new List<PhoneModel>();
        }
    }
}
