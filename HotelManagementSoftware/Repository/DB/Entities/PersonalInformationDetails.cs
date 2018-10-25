using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class PersonalInformationDetails
    {
        public PersonalInformationDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]

        public Guid Id { get; set; }
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