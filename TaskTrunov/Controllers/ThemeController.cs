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
    public class ThemeController : Controller
    {
        private readonly IThemeRepository _themeRepository;

        public ThemeController(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }
        // GET: api/theme
        public IEnumerable<ThemeDto> Get()
        {
            return _themeRepository.GetThemeRecords();
        }

        // GET api/theme/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var theme = _themeRepository.GetThemeSingleRecord(id);
            if (theme != null)
            {
                return Ok(theme);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/theme
        [HttpPost]
        public IActionResult Post([FromBody]ThemeDto theme)
        {
            if (ModelState.IsValid)
            {
                _themeRepository.AddThemeRecord(theme);
                return Ok(theme);
            }
            return BadRequest();
        }
    }
}
