using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{ Id=101,Name="HP Laptop",Price=40000},
                 new Product{ Id=102,Name="Dell Laptop",Price=420000},
                  new Product{ Id=101,Name="Lenovo Laptop",Price=440000},
            };

            ViewBag.ProductList = plist;
            return View();
        }

        [HttpGet] // by default it is HttpGet
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Create( IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("Details");
        }
    }
}
