using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class PaymentDetails
    {      

        public PaymentDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public int CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
    }
}