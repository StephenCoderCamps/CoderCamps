using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManager.Infrastructure
{
    public class ContactsDB:DbContext
    {
        public IDbSet<Contact> Contacts { get; set; }


    }
}