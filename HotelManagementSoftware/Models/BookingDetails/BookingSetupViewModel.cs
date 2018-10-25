using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Models.BookingDetails
{
    public class BookingSetupViewModel
    {
        public DateTime BookingDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int BookingRef { get; set; }

        public int Totalrent { get; set; }
        public int Totalbond { get; set; }
        public int TotalPaid { get; set; }
        public int Totalbalance { get; set; }
        public int TotalGST { get; set; }

        public DateTime DateTime { get; set; }

    }
}