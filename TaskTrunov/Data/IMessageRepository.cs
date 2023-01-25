using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public interface IMessageRepository
    {
        void AddMessageRecord(MessageDto message);
        MessageDto GetMessageSingleRecord(int idTheme, int idContact);
        MessageDto GetMessageSingleRecord(int id);
    }
}
