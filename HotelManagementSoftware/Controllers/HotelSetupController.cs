using HotelManagementSoftware.Models;
//using HotelManagementSoftware.Models.AddressDetails;
using HotelManagementSoftware.Models.BookingDetails;
//using HotelManagementSoftware.Models.ContactDetails;
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
    public class HotelSetupController : Controller // Controller will handover the data to repository
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


        // GET: HotelSetup
        public ActionResult Index()
        {

            return View("HotelSetup");
        }

        [HttpPost]
        public bool UpdateHotelDetails(HotelSetupViewModel viewModel)
        {
            var hotelDetailsModel = new HotelDetailsModel()
            {
                HotelName = viewModel.HotelName,
                CompanyName = viewModel.CompanyName,
                BusinessNumber = Convert.ToInt32(viewModel.BusinessNumber),
            };

            Repository.UpdateHotelInformation(hotelDetailsModel);          

            var contactDetailsModel = new ContactDetailsModel()
            {
                Taxid = viewModel.Taxid, 
                TelephoneNumber = viewModel.Telephone,
                FaxNumber = viewModel.FaxNumber,
                EmailAddress = viewModel.EmailAddress,
                CountryCode = viewModel.CountryCode,
                PostalCode = viewModel.PostalCode,
            };
            Repository.UpdateContactInformation(contactDetailsModel);

            var addressDetailsModel = new AddressDetailsModel()
            {
                Address = viewModel.Address,
                City = viewModel.City,
                CityCode = viewModel.CityCode,
                State = viewModel.State,
            };
            Repository.UpdateAddressInformation(addressDetailsModel);

            var logoDetailsModel = new LogoDetailsModel()
            {
                Website = viewModel.Website,
                Logo= viewModel.Logo,
                Skype= viewModel.Skype,
                Language= viewModel.Language,
            };
            Repository.UpdateLogoInformation(logoDetailsModel);
            return true;
        }        
       
    };
}