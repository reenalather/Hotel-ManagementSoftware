using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class ContactDetails
    {
        public ContactDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public int Taxid { get; set; }
        public int TelephoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CountryCode { get; set; }
        public int PostalCode { get; set; }

        //public List<HotelDetails> HotelDetails { get; set; }
        public DateTime DateTime { get; internal set; }
    }
}