using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class AddressDetails
        //This is the properties and classes of the tables
    {

        public AddressDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string State { get; set; }
        public DateTime DateTime { get; set; }
    

    }
}