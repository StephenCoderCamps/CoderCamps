using CoderCamps;
using ContactManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Services
{
    public class ContactService : ContactManager.Services.IContactService
    {
        private IGenericRepository _repo;
        public ContactService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<Contact> ListContacts()
        {
            return (from m in _repo.Query<Contact>()
             select m).ToList();
        }

        public Contact Find(int id)
        {
            return _repo.Find<Contact>(id);
        }

        public void Create(Contact contact)
        {
            _repo.Add(contact);
            _repo.SaveChanges();
        }

        public void Edit(Contact contact)
        {
            var original = this.Find(contact.Id);
            original.FirstName = contact.FirstName;
            original.LastName = contact.LastName;
            original.Birthdate = contact.Birthdate;
            original.Phone = contact.Phone;
            original.Email = contact.Email;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Contact>(id);
            _repo.SaveChanges();
        }
    }
}