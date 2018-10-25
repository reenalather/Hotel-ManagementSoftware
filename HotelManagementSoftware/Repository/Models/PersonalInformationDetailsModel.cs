using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class PersonalInformationDetailsModel
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string CountryOrRegion { get; set; }
        public string Nationality { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string AdditionalMessage { get; set; }
    }
}