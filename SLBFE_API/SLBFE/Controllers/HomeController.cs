﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLBFE.Controllers
{
    /// <summary>
    /// This controllder is to load the home page
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Start point
        /// </summary>
        /// <returns>The view of the home page</returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            Models.DataStore.InitializeDatabase(); // This line initializes the database on the first run

            return View();
        }
    }
}
