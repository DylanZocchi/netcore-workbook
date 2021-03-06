﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaseProject.Models;

namespace BaseProject.Controllers
{
    
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]      // Combines to define the route template "Home"
        [Route("Index")] // Combines to define the route template "Home/Index"
        [Route("/")]     // Doesn't combine, defines the route template ""
        public IActionResult Index()
        {
            return View();
        }




        [Route("About")]
        [HttpPost]
        public IActionResult About(Name name)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            Console.WriteLine(name.FirstName);

            return Redirect(nameof(About));
        }


        [Route("About")]
        [HttpGet]


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var name = new Name
            {
                FirstName = "Dylan",
                LastName = "Zocchi"
            };
        return View(name);

        }





        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
