﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaseProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseProject.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public ActionResult List()
        {
            return View(new List<User>());
        }
    }
}
