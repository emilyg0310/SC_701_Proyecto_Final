﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Api.Controllers
{
    public class MediParedesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}