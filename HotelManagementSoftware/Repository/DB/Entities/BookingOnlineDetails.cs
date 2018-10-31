using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class BookingOnlineDetails
    {
        public BookingOnlineDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key] //it will create a primary key for Guid ID in the database
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string RoomType { get; set; }
        public int TotalPerson { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }

    }
}