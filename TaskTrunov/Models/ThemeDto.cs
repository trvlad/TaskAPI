using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrunov.Models
{
    public class ThemeDto
    {
        public int id { get; set; }
        public string theme { get; set; }

        public ThemeDto()
        {
            this.id = 0;
            this.theme = "";
        }

        public ThemeDto(int id, string themeText)
        {
            this.id = id;
            this.theme = themeText;
        }
    }
}
