using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrunov.Models
{
    public class ContactDto
    {
        public int id { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string name { get; set; }


        public ContactDto()
        {
            this.id = 0;
            this.email = "";
            this.phoneNumber = "";
            this.name = "";
        }

        public ContactDto(int id, string email, string phoneNumber, string name)
        {
            this.id = id;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.name = name;
        }

    }
}
