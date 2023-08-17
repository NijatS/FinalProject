using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Staff:BaseEntity
    {
        public string FullName { get; set; }
        public string Info { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public string Image { get; set; }
        public string ImageUrl { get; set; }
        public List<Social>? Socials { get; set; }
    }
}
