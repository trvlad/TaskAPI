using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrunov.Models
{
    public class MessageDto
    {
        public int id { get; set; }
        public int idTheme { get; set; }
        public int idContact { get; set; }
        public string message { get; set; }
        public DateTime dateTimeMessage { get; set; }

        public MessageDto()
        {
            this.id = 0;
            this.idTheme = 0;
            this.idContact = 0;
            this.message = "";
            this.dateTimeMessage = new DateTime();
        }

        public MessageDto(int id,int idTheme, int idContact, string messageText, DateTime dateTimeMassage)
        {
            this.id = id;
            this.idTheme = idTheme;
            this.idContact = idContact;
            this.message = messageText;
            this.dateTimeMessage = dateTimeMassage;
        }

    }
}
