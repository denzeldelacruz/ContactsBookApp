using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactsBookApp.Models;

namespace ContactsBookApp.Controllers
{
    public class ContactController : Controller
    {
        private ContactDbContext db = new ContactDbContext();

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Contacts = db.Contacts.ToList();
            return View();
        }
    }
}