using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class BookingDetailsModel
    {
        public DateTime BookingDate { get; internal set; }
        public DateTime DepartureDate { get; internal set; }
        public int BookingRef { get; internal set; }
        public DateTime DateTime { get; set; }

    }
}