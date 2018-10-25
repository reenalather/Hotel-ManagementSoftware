using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class HotelDetails //Entitites are exactly copy of what has been to store in the database.Defines the database
    {


        public HotelDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public int BusinessNumber { get; set; }

        public DateTime DateTime { get; set; }


    }
}