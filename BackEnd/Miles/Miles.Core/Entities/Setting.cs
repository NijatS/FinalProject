using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
	public class Setting:BaseEntity
	{
		public string Address { get; set; }
		public string Phone1 { get; set; }
		public string Phone2 { get; set; }
		public string Email { get; set; }
		public string Logo { get; set; }
		public string LogoUrl { get; set; }
		public string PhotoWhy { get; set; }
		public string PhotoWhyUrl { get; set; }
		public List<TextWhy> TextWhies { get; set; }
		public List<Social> Socials { get; set; }
	}
}
