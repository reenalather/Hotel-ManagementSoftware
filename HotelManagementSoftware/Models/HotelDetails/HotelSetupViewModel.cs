using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Models
{
    public class HotelSetupViewModel  // This folder is inbetween views and entities where it reflecting what data repository is expecting as a whole set.
        // validation of the data for the repository
    {
        public int HotelId { get; set; }
        public string CompanyName {get;set;}
        public string HotelName { get; set; }
        public string BusinessNumber { get; set; }
        public int Taxid { get; set; }
        public int Telephone { get; set; }
        public int FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CountryCode { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string State { get; set; }
        public string Website { get; set; }
        public byte[] Logo { get; set; }
        public string Skype { get; set; }
        public string Language { get; set; }

        DateTime Datetime { get; set; }

    }
}