using CarParkProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkProject.Web.Controllers
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

        public IActionResult CustomerMethots()
        {
            return View();
        }
        public IActionResult CustomerMethotsDetail()
        {
            return View();
        }
        public IActionResult CarMethots()
        {
            return View();
        }
        public IActionResult PaymentMethots()
        {
            return View();
        }
        public IActionResult SubscribeMethots()
        {
            return View();
        }
        public IActionResult SettingsMethots()
        {
            return View();
        }
        public IActionResult TicketMethods()
        {
            return View();
        }
        public IActionResult Reports()
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
    }
}
