using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class HotelDetailsModel
    {      

        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public int BusinessNumber { get; set; }

        public DateTime DateTime { get; set; }

    }
}