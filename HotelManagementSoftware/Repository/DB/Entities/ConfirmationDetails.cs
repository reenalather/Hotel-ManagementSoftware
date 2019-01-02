using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class ConfirmationDetails
    {

        public ConfirmationDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]

        public Guid Id { get; set; }
        public string BookingNumber
        {
            get {

                return Id.ToString();
            }

          }
        public string EmailAddress { get; set; }
        public string YourReservation { get; set; }
        //public DateTime CheckIn { get; set; }
        //public DateTime CheckOut { get; set; }
        public bool GST { get; set; }
        public bool TotalPrice { get; set; }       

        public DateTime DateTime { get; set; }


    }
}