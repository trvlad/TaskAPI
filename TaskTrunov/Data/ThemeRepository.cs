using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public class ThemeRepository : IThemeRepository
    {
        private readonly ApplicationContext _context;

        public ThemeRepository(ApplicationContext context)
        {
            _context = context;
        }


        public void AddThemeRecord(ThemeDto theme)
        {
            Console.WriteLine(theme);
            _context.Themes.Add(theme);
            _context.SaveChanges();
        }

        public List<ThemeDto> GetThemeRecords()
        {
            return _context.Themes.ToList();
        }

        public ThemeDto GetThemeSingleRecord(int id)
        {
            return _context.Themes.FirstOrDefault(t => t.id == id);
        }
    }
}
