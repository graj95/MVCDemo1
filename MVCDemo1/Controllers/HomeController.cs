using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Controllers
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
            ViewData["message"] = " This is my mvc application";
            string[] name = { "tushar", "rajash", "rahul", "Kishor" };

            ViewData["nameslist"] = name;

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=1, Name= "Tushar",Department= "IT", Salary=25000},
                 new Employee{Id=2, Name= "Rahul",Department= "IT", Salary=20000},
                  new Employee{Id=3, Name= "Kishor",Department= "Admin", Salary=45000},
                   new Employee{Id=4, Name= "Prakash",Department= "BA", Salary=35000}

            };
            ViewData["emplist"] = emplist;

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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
