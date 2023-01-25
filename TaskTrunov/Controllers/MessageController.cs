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
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        // GET api/message?id_Theme&id_Contact
        [HttpGet]
        public IActionResult Get([FromQuery] int idTheme, [FromQuery] int idContact)
        {
            var message = _messageRepository.GetMessageSingleRecord(idTheme, idContact);
            if (message != null)
            {
                return Ok(message);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/message/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var message = _messageRepository.GetMessageSingleRecord(id);
            if (message != null)
            {
                return Ok(message);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/message
        [HttpPost]
        public IActionResult Post([FromBody]MessageDto message)
        {
            if (ModelState.IsValid)
            {
                _messageRepository.AddMessageRecord(message);
                return Ok(message);
            }
            return BadRequest();
        }
    }
}
