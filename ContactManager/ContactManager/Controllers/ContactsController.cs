using ContactManager.Models;
using ContactManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactsController : Controller
    {
        private IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = _contactService.ListContacts();
            return View(contacts);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            var contact = _contactService.Find(id);

            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid) {
                _contactService.Create(contact);
                return RedirectToAction("Index");
            }
            return View();

        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            var contact = _contactService.Find(id);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid) {
                _contactService.Edit(contact);
                return RedirectToAction("Index");
            }

            return View();

        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            var contact = _contactService.Find(id);
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("Index");
            
        }
    }
}
