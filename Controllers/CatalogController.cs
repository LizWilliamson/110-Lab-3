using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class CatalogController : Controller {

        public IActionResult Index(){
            return View();
        }

        public IActionResult Register(){
            return View();

        }

        [HttpPost]
        public IActionResult SaveCar( [FromBody] Car theCar ){
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine("User wants to save a car ", theCar);
            Console.WriteLine(theCar);
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");

            return Json(theCar);
        }

    }
}