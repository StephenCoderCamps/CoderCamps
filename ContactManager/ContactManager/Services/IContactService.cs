using System;
namespace ContactManager.Services
{
    public interface IContactService
    {
        void Create(ContactManager.Models.Contact contact);
        void Delete(int id);
        void Edit(ContactManager.Models.Contact contact);
        ContactManager.Models.Contact Find(int id);
        System.Collections.Generic.IList<ContactManager.Models.Contact> ListContacts();
    }
}
