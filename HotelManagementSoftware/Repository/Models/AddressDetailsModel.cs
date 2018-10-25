using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class AddressDetailsModel
    {
        
        public string Address { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string State { get; set; }

       // DateTime Datetime { get; set; }

        //public List<HotelDetailsModel> HotelDetailsModel { get; set; }

    }
}