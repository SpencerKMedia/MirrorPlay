﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MirrorPlay.Areas.U.Controllers
{
    public class DashboardController : Controller
    {
        // GET: U/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}