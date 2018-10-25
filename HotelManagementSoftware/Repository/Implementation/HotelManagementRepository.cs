using HotelManagementSoftware.Models;
using HotelManagementSoftware.Repository.DB;
using HotelManagementSoftware.Repository.DB.Entities;
using HotelManagementSoftware.Repository.Models;
using System;
using System.Runtime.Remoting.Contexts;

namespace HotelManagementSoftware.Repository.Implementation
{
    public class HotelManagementRepository : IHotelManagementRepository  // is a facade/front for interacting the database,
                                                                         // makes like the pretending the database, collection of the objects of the databse.Like if we are entering any new data in the database you dont need to go to directly 
                                                                         //to the databse but only you can add to repository, repository will contact to databse itself and update the information there.                                                                        
    {
        private HotelManagementSystemContext _context;
        private HotelManagementSystemContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new HotelManagementSystemContext();
                }
                return _context;
            }
        }


        Guid IHotelManagementRepository.UpdateAddressInformation(AddressDetailsModel model)
        {
            var entity = new AddressDetails()
            {
                Address = model.Address,
                City = model.City,
                CityCode = model.CityCode,
                State = model.State,
                DateTime = DateTime.UtcNow
            };

            Context.AddressDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        Guid IHotelManagementRepository.UpdateContactInformation(ContactDetailsModel model)
        {
            var entity = new ContactDetails()
            {
                Taxid = model.Taxid,
                TelephoneNumber = model.TelephoneNumber,
                FaxNumber = model.FaxNumber,
                EmailAddress = model.EmailAddress,
                CountryCode = model.CountryCode,
                PostalCode = model.PostalCode,
                DateTime = DateTime.UtcNow
            };
            Context.ContactDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;

        }

        Guid IHotelManagementRepository.UpdateHotelInformation(HotelDetailsModel model)
        {
            var entity = new HotelDetails()
            {
                HotelName = model.HotelName,
                CompanyName = model.CompanyName,
                BusinessNumber = model.BusinessNumber,
                DateTime = DateTime.UtcNow

            };

            Context.HotelDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        Guid IHotelManagementRepository.UpdateBookingInformation(BookingDetailsModel model)
        {
            var entity = new BookingDetails()
            {
                BookingDate = model.BookingDate,
                DepartureDate = model.DepartureDate,
                BookingRef = model.BookingRef,
                DateTime = DateTime.UtcNow,
            };
            Context.BookingDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        Guid IHotelManagementRepository.UpdateRentInformation(RentDetailsModel model)
        {
            var entity = new RentDetails()
            {
                Totalrent = model.Totalrent,
                Totalbond = model.Totalbond,
                TotalPaid = model.TotalPaid,
                Totalbalance = model.Totalbalance,
                TotalGST = model.TotalGST,
                DateTime = DateTime.UtcNow,

            };
            Context.RentDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        public Guid UpdateRoomInformation(RoomDetailsModel model)
        {
            var entity = new RoomDetails()
            {
                HotelName = model.HotelName,
                BookingAddress = model.BookingAddress,
                RoomNumber = model.RoomNumber,
                RoomType = model.RoomType,
                RoomStatus = model.RoomStatus,
                RoomRate = model.RoomRate,
                NoOfPerson = model.NoOfPerson,
                DateTime = DateTime.UtcNow,
            };

            Context.RoomDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        public Guid UpdateLogoInformation(LogoDetailsModel model)
        {
            var entity = new LogoDetails()
            {
                Website = model.Website,
                Logo = model.Logo,
                Skype = model.Skype,
                Language = model.Language,
                DateTime = DateTime.UtcNow,
            };

            Context.LogoDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;

        }


        public Guid UpdatePersonalInformation(PersonalInformationDetailsModel model)
        {

            var entity = new PersonalInformationDetails()
            {
                FirstName = model.FirstName,
                SurName = model.SurName,
                CountryOrRegion = model.CountryOrRegion,
                Nationality = model.Nationality,
                PhoneNumber = model.PhoneNumber,
                EmailAddress = model.EmailAddress,
                Address = model.Address,
                ZipCode = model.ZipCode,
                AdditionalMessage = model.AdditionalMessage,

            };
            Context.PersonalInformationDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;

        }

        public Guid UpdateBookingOnlineInformation(BookingOnlineDetailsModel model)
        {
            var entity = new BookingOnlineDetails()
            {
                ArrivalDate = model.ArrivalDate,
                DepartureDate = model.DepartureDate,
                RoomType = model.RoomType,
                TotalPerson = model.TotalPerson,
                Adult = model.Adult,
                Children = model.Children,
            };
            Context.BookingOnlineDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        public Guid UpdatePaymentInformation(PaymentDetailsModel model)
        {
            var entity = new PaymentDetails()
            {
                CardNumber = model.CardNumber,
                SecurityCode = model.SecurityCode,
                ExpireMonth = model.ExpireMonth,
                ExpireYear = model.ExpireYear,

            };

            Context.PaymentDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }

        public Guid UpdateConfirmationInformation(ConfirmationDetailsModel model)
        {
            var entity = new ConfirmationDetails()

            {
                BookingNumber = model.BookingNumber,
                YourReservation = model.YourReservation,
                //CheckIn = model.CheckIn,
                //CheckOut = model.CheckOut,
                GST = model.GST,
                TotalPrice = model.TotalPrice,


            };
            Context.ConfirmationDetails.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }
    }
}
