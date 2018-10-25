using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class ContactDetailsModel
    {
               
        public int Taxid { get; set; }
        public int TelephoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CountryCode { get; set; }
        public int PostalCode { get; set; }

        //public List<HotelDetailsModel> HotelDetailsModel { get; set; }

    }
}