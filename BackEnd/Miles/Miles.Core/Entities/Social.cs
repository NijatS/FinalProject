using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
	public class Social:BaseEntity
	{
		public string Icon { get; set; }
		public string Link { get; set; }
		public int? StaffId { get; set; }
		public Staff? Staff { get; set; }
		public int? SettingId { get; set; }
		public Setting? Setting { get; set; }
	}
}
