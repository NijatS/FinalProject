using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.TextWhies
{
    public class TextWhyPostDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public int SettingId { get; set; }
    }
}
