using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Socials
{
    public class SocialPostDto
    {
		public string Icon { get; set; }
		public string Link { get; set; }
		public int? StaffId { get; set; }
		public int? SettingId { get; set; }
	}
}
