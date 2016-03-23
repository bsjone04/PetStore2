using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part2Demo.Models
{
    public class Speaker : Controller
    {
        // GET: Speaker
        public ActionResult Index()
        {
            return View();
        }
    }
}