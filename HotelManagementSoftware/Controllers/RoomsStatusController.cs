using HotelManagementSoftware.Repository;
using HotelManagementSoftware.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagementSoftware.Controllers
{
    public class RoomsStatusController : Controller
    {

        private IHotelManagementRepository _repository;
        private object veiwModel;

        private IHotelManagementRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new HotelManagementRepository();
                }
                return _repository;
            }
        }

        // GET: RoomsStatus
        public ActionResult Index()
        {
            return View("RoomsStatus");
        }

        }
}

//public Form1()
//{
//    InitializeComponent();

//    calendar1.CalendarDate = DateTime.Now;
//    calendar1.CalendarView = CalendarViews.Month;
//}

//public bool UpdateRoomStatusDetails(RoomsStatusViewModel viewModel)
//{


//    var dp = new DayPilot.Scheduler("dp");
//    dp.startDate = DayPilot.Date.today().firstDayOfMonth();
//    dp.days = DayPilot.Date.today().daysInMonth();
//    dp.scale = "Day";
//    dp.timeHeaders = [
//        { groupBy: "Month", format: "MMMM yyyy" },
//        { groupBy: "Day", format: "d" }
//    ];
//    dp.init();