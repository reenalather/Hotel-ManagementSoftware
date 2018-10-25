using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB.Entities
{
    public class LogoDetails
    {
        public LogoDetails()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Website { get; set; }
        public byte[] Logo { get; set; }
        public string Skype { get; set; }
        public string Language { get; set; }

        public DateTime DateTime { get; set; }


    }
}