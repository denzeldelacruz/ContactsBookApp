using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsBookApp.Models
{
    [Table("tbl_contact")]
    public class Contact
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string contact_no { get; set; }
        public string email_addr { get; set; }
        public string addr { get; set; }
        public int? vip { get; set; }
    }

    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}