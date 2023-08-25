using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Comment:BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int? BlogId { get; set; }
        public Blog? Blog { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public int CarID { get; set; }
    }
}
