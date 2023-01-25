using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskTrunov.Data;
using TaskTrunov.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskTrunov.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        // GET api/contact?Email=...&PhoneNumber=...
        [HttpGet]
        public IActionResult Get([FromQuery] string email, [FromQuery] string phoneNumber)
        {
            var contact = _contactRepository.GetContactSingleRecord(email, phoneNumber);
            if (contact != null)
            {
                return Ok(contact);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/contact/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contact = _contactRepository.GetContactSingleRecord(id);
            if (contact != null)
            {
                return Ok(contact);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/contact
        [HttpPost]
        public IActionResult Post([FromBody]ContactDto contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.AddContactRecord(contact);
                return Ok(contact);
            }
            return BadRequest();
        }
    }
}
