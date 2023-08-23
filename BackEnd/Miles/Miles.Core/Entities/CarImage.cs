using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
	public class CarImage:BaseEntity
	{
		public string Image { get; set; }
		public string ImageUrl { get; set; }
		public int CarId { get; set; }
		public Car Car { get; set; }
		public bool isMain { get; set; }
	}
}
