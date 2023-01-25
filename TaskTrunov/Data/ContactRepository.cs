using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationContext _context;

        public ContactRepository(ApplicationContext context)
        {
            _context = context;
        }


        public void AddContactRecord(ContactDto contact)
        {
            Console.WriteLine(contact);
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public ContactDto GetContactSingleRecord(string email, string phoneNumber)
        {
            phoneNumber = "+" + phoneNumber.Substring(1);
            return _context.Contacts.FirstOrDefault(t => t.email == email && t.phoneNumber==phoneNumber);
        }

        public ContactDto GetContactSingleRecord(int id)
        {
            return _context.Contacts.FirstOrDefault(t => t.id == id);
        }
    }
}
