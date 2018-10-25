using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.Models
{
    public class LogoDetailsModel
    {
        public string Website { get; set; }
        public byte[] Logo { get; set; }
        public string Skype { get; set; }
        public string Language { get; set; }

        public DateTime DateTime { get; set; }
    }
}