using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Models
{
    public class BookingOnlineViewModel
    {


        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string RoomType { get; set; }
        public int TotalPerson { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }


        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string CountryOrRegion { get; set; }
        public string Nationality { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string AdditionalMessage { get; set; }




        public int CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }


        public string BookingNumber { get; set; }        
        public string YourReservation { get; set; }
        //public DateTime CheckIn { get; set; }
        //public DateTime CheckOut { get; set; }
        public bool GST { get; set; }
        public bool TotalPrice { get; set; }

        public DateTime DateTime { get; set; }


    }
}