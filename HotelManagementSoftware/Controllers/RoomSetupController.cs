using HotelManagementSoftware.Models.RentDetails;
using HotelManagementSoftware.Repository;
using HotelManagementSoftware.Repository.Implementation;
using HotelManagementSoftware.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagementSoftware.Controllers
{
    public class RoomSetupController : Controller
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

        // GET: RoomSetup
        public ActionResult Index()
        {
            return View("RoomSetup");
        }

        [HttpPost]
        public bool UpdateRoomDetails(RoomSetupViewModel viewModel)
        {

            var roomDetailsModel = new RoomDetailsModel()
            {
                HotelName = viewModel.HotelName,
                BookingAddress= viewModel.BookingAddress,
                RoomNumber=viewModel.RoomNumber,
                RoomType= viewModel.RoomType,
                RoomStatus= viewModel.RoomStatus,
                RoomRate= viewModel.RoomRate,
                NoOfPerson= viewModel.NoOfPerson,
                DateTime = DateTime.UtcNow,
            };

            Repository.UpdateRoomInformation(roomDetailsModel);
            return true;

        }
    }
}