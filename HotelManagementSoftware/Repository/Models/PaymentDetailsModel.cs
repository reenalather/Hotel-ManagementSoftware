using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class PaymentDetailsModel
    {
        public int CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
    }
}