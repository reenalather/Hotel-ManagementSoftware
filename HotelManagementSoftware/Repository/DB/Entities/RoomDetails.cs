using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class RoomDetails
    {
        public RoomDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string HotelName { get; set; }
        public string BookingAddress { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        public string RoomStatus { get; set; }
        public int NoOfPerson { get; set; }
        public string RoomRate { get; set; }

        public DateTime DateTime { get; set; }
        


    }
}