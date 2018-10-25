using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class BookingOnlineDetailsModel
    {
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string RoomType { get; set; }
        public int TotalPerson { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }

    }
}