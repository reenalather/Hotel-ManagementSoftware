using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class ConfirmationDetailsModel
    {
        public string BookingNumber { get; set; }
        public string EmailAddress { get; set; }
        public string YourReservation { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool GST { get; set; }
        public bool TotalPrice { get; set; }

        public DateTime DateTime { get; set; }
    }
}