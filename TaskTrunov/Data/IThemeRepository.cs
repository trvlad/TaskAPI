using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrunov.Models;

namespace TaskTrunov.Data
{
    public interface IThemeRepository
    {
        void AddThemeRecord(ThemeDto theme);
        ThemeDto GetThemeSingleRecord(int id);
        List<ThemeDto> GetThemeRecords();
    }
}
