using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class RentDetailsModel
    {
        public int Totalrent { get; set; }      
        public int Totalbond { get; set; }
        public int TotalPaid { get; set; }
        public int Totalbalance { get; set; }
        public int TotalGST { get; set; }

        public DateTime DateTime { get; set; }
    }
        
}