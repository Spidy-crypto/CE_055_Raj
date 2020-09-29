using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab8_task4.Models;

namespace Lab8_task4.Controllers
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

        public IActionResult Test1()
        {
            int n1 = 2;
            int n2 = 3;
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.result = n1 + n2;
            return View();
        }

        public IActionResult user_registration()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test2(string num1,string num2)
        {
            int ans = int.Parse(num1) + int.Parse(num2);
            ViewBag.ans = ans;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
