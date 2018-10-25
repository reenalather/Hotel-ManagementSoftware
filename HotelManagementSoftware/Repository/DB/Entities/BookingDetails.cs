using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class BookingDetails
    {
        public BookingDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime BookingDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int BookingRef { get; set; }
        public DateTime DateTime { get; set; }
        

    }
}