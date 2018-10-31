using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class RentDetails
    {
        public RentDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key] //it will create a primary key for Guid ID in the database
        public Guid Id { get; set; }     
        public int Totalrent { get; set; }
        public int Totalbond { get; set; }
        public int TotalPaid { get; set; }
        public int Totalbalance { get; set; }
        public int TotalGST { get; set; }
        public DateTime DateTime { get; set; }

    }
}