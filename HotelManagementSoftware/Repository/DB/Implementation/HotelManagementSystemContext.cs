using HotelManagementSoftware.Repository.DB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelManagementSoftware.Repository.DB
{
    public class HotelManagementSystemContext : DbContext// in the dbcontext - dbset and save changes method
    {
        // define a base constructor to the dbcontext, connect to the database, this is also telling the dbcontext to call the db with the name of default connection.
        public HotelManagementSystemContext() : base("DefaultConnection")
        {

        }

        //ALl below are the table's refernece from the database in the plural form(called mapping class)

        public DbSet<HotelDetails> HotelDetails { get; set; }// created a new object of the entity class
        // the table that it should be creating in the database, in my database i have collection of team objects 
        public DbSet<ContactDetails> ContactDetails { get; set; }  // query and save the instances/objects of the model
        public DbSet<AddressDetails> AddressDetails { get; set; }// dbset- add(obj), Remove(obj), Find(obj), Where(predicate)
        public DbSet<LogoDetails> LogoDetails { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<RentDetails> RentDetails { get; set; }
        public DbSet<RoomDetails> RoomDetails { get; set; }      
        public DbSet<BookingOnlineDetails> BookingOnlineDetails { get; set; }
        public DbSet<PersonalInformationDetails> PersonalInformationDetails { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<ConfirmationDetails> ConfirmationDetails { get; set; }

        


    }
}