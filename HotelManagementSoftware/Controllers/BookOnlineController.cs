using HotelManagementSoftware.Models;
using HotelManagementSoftware.Repository;
using HotelManagementSoftware.Repository.Implementation;
using HotelManagementSoftware.Repository.Models;
using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


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

        //Validation of the fileds
        public static void CheckNull(object element, string message)
        {
            if (element == null)
            {
                throw new Exception(message);
            }
        }        

        public static void IsValid(string value, string message)
        {
            if (value == null)
            {
                throw new Exception(message);
            }

        }

        public static void IsValid(int number, string message)
        {
            if (number < 1)
            {
                throw new Exception(message);

            }
        }

        public static void IsValidmail(string email, string message)
        {

            if (email == null)
            {
                throw new MissingFieldException(message);
            }
        }

        public static void IsValid(bool value, string message)
        {
            if (value == false)
            {
                throw new Exception(message);
            }
        }


        [HttpPost]
        public Boolean UpdateBookingDetails(BookingOnlineViewModel viewmodel)
        {
            CheckNull(viewmodel.ArrivalDate, "Please enter arrival date");
            CheckNull(viewmodel.DepartureDate, "Please enter the Departure date");
            CheckNull(viewmodel.RoomType, "Please Enter Room Type");
            CheckNull(viewmodel.FirstName, "Please enter Firstname");
            CheckNull(viewmodel.SurName, "Please enter Surname");
            CheckNull(viewmodel.CountryOrRegion, "Please enter Country Name");
            CheckNull(viewmodel.Nationality, "Please enter Nationality");
            CheckNull(viewmodel.Address, "Please enter address");
            CheckNull(viewmodel.ExpireMonth, "Please enter expiry month");
            CheckNull(viewmodel.ExpireYear, "Please enter expiry year");
            CheckNull(viewmodel.YourReservation, "Please enter reserve rooms");



            IsValid(viewmodel.Adult, "Please choose the value");
            IsValid(viewmodel.Children, "Please choose the value");
            IsValid(viewmodel.TotalPerson, "Please choose the value");
            IsValid(viewmodel.PhoneNumber, "Please enter the PhoneNumber");
            IsValid(viewmodel.ZipCode, "Please enter Zip Code");
            IsValid(viewmodel.CardNumber, "please enter card number");
            IsValid(viewmodel.SecurityCode, "please enter security code");
            IsValid(viewmodel.BookingNumber, "please enter booking number");
            IsValid(viewmodel.GST, "please enter GST");
            IsValid(viewmodel.TotalPrice, "please enter the total price");


            IsValidmail(viewmodel.EmailAddress, "Please enter valid email address");


            var bookingOnlineDetailsModel = new BookingOnlineDetailsModel()
            {
                ArrivalDate = viewmodel.ArrivalDate,
                DepartureDate = viewmodel.DepartureDate,
                RoomType = viewmodel.RoomType,
                Adult = viewmodel.Adult,
                Children = viewmodel.Children,
                TotalPerson = viewmodel.TotalPerson,

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
                CreatedTime = DateTime.UtcNow,
                GST = viewmodel.GST,
                TotalPrice = viewmodel.TotalPrice,
            };
            Repository.UpdateConfirmationInformation(confirmationDetailsModel);
            return true;
        }
    };
}