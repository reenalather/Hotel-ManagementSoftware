using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagementSoftware.Controllers
{
    public class AdminSetupController : Controller
    {
        // GET: AdminSetup
        public ActionResult Index()
        {
            return View("AdminSetup");
        }
    }
}