using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationContext _context;

        public MessageRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddMessageRecord(MessageDto message)
        {
            Console.WriteLine(message);
            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public MessageDto GetMessageSingleRecord(int idTheme, int idContact)
        {
            return _context.Messages.FirstOrDefault(t => t.idTheme == idTheme && t.idContact == idContact);
        }

        public MessageDto GetMessageSingleRecord(int id)
        {
            return _context.Messages.FirstOrDefault(t => t.id == id);
        }
    }
}
