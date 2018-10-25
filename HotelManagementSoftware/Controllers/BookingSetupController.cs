using HotelManagementSoftware.Models.BookingDetails;
using HotelManagementSoftware.Repository;
using HotelManagementSoftware.Repository.Implementation;
using HotelManagementSoftware.Repository.Models;
using HotelManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelManagementSoftware.Models.RentDetails;

namespace HotelManagementSoftware.Controllers
{
    public class BookingSetupController : Controller
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

               // GET: BookingSetup
        public ActionResult Index()
        {
            return View("BookingSetup");
        }

        [HttpPost]

        //Booking Details
        public bool UpdateBookingDetails(BookingSetupViewModel viewModel)
        {

            var bookingDetailsModel = new BookingDetailsModel()
            {
                BookingDate = viewModel.BookingDate,
                DepartureDate = viewModel.DepartureDate,
                BookingRef = viewModel.BookingRef,

            };
            Repository.UpdateBookingInformation(bookingDetailsModel);

        //Rent Details
            var rentDetailsModel = new RentDetailsModel()
            {

                Totalrent = viewModel.Totalrent,
                Totalbond = viewModel.Totalbond,
                TotalPaid = viewModel.TotalPaid,
                Totalbalance = viewModel.Totalbalance,
                TotalGST = viewModel.TotalGST,

            };

            Repository.UpdateRentInformation(rentDetailsModel);
            return true;
        }
    }
}