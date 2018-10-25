
using HotelManagementSoftware.Models;
using HotelManagementSoftware.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository
{
    public interface IHotelManagementRepository
    {
        Guid UpdateHotelInformation(HotelDetailsModel model);
        Guid UpdateContactInformation(ContactDetailsModel model);

        Guid UpdateAddressInformation(AddressDetailsModel model);
        Guid UpdateLogoInformation(LogoDetailsModel model);

        Guid UpdateBookingInformation(BookingDetailsModel model);

        Guid UpdateRentInformation(RentDetailsModel model);

        Guid UpdateRoomInformation(RoomDetailsModel model);

        Guid UpdateBookingOnlineInformation(BookingOnlineDetailsModel model);

        Guid UpdatePersonalInformation(PersonalInformationDetailsModel model);

        Guid UpdatePaymentInformation(PaymentDetailsModel model);

        Guid UpdateConfirmationInformation(ConfirmationDetailsModel model);
       
    }
}