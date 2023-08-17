using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
	public class AboutSkill:BaseEntity
	{
		public string Name { get; set; }
		public int Degree { get; set; }
	}
}
