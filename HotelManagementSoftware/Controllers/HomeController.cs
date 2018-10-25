using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HotelManagementSoftware.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}
