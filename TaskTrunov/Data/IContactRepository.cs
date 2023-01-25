using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public interface IContactRepository
    {
        void AddContactRecord(ContactDto contact);
        ContactDto GetContactSingleRecord(string email, string phoneNumber);
        ContactDto GetContactSingleRecord(int id);
    }
}
