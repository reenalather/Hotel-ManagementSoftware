using HotelManagementSoftware.Models;
using HotelManagementSoftware.Repository;
using HotelManagementSoftware.Repository.Implementation;
using HotelManagementSoftware.Repository.Models;
using System;
using System.Web.Mvc;

namespace HotelManagementSoftware.Controllers
{
    public class BookOnlineController : Controller
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
        // GET: BookingOnline
        public ActionResult Index()
        {
            return View("BookOnline");
        }

        [HttpPost]
        public Boolean UpdateBookingDetails(BookingOnlineViewModel viewmodel)
        {
            var bookingOnlineDetailsModel = new BookingOnlineDetailsModel()
            {
                ArrivalDate = viewmodel.ArrivalDate,
                DepartureDate = viewmodel.DepartureDate,
                RoomType = viewmodel.RoomType,
                TotalPerson = viewmodel.TotalPerson,
                Adult = viewmodel.Adult,
                Children = viewmodel.Children,

            };
            Repository.UpdateBookingOnlineInformation(bookingOnlineDetailsModel);

            var personalInformationDetailsModel = new PersonalInformationDetailsModel()
            {

                FirstName = viewmodel.FirstName,
                SurName = viewmodel.SurName,
                CountryOrRegion = viewmodel.CountryOrRegion,
                Nationality = viewmodel.Nationality,
                PhoneNumber = viewmodel.PhoneNumber,
                EmailAddress = viewmodel.EmailAddress,
                Address = viewmodel.Address,
                ZipCode = viewmodel.ZipCode,
                AdditionalMessage = viewmodel.AdditionalMessage,
            };
            Repository.UpdatePersonalInformation(personalInformationDetailsModel);


            var paymentDetailsModel = new PaymentDetailsModel()
            {
                CardNumber = viewmodel.CardNumber,
                SecurityCode = viewmodel.SecurityCode,
                ExpireMonth = viewmodel.ExpireMonth,
                ExpireYear = viewmodel.ExpireYear,

            };

            Repository.UpdatePaymentInformation(paymentDetailsModel);

            var confirmationDetailsModel = new ConfirmationDetailsModel()
            {
                BookingNumber = viewmodel.BookingNumber,
                YourReservation = viewmodel.YourReservation,
                //CheckIn = viewmodel.CheckIn,
                //CheckOut = viewmodel.CheckOut,
                GST = viewmodel.GST,
                TotalPrice = viewmodel.TotalPrice,
            };
            Repository.UpdateConfirmationInformation(confirmationDetailsModel);
            return true;
        }
    };
}