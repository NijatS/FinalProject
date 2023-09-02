using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CarId { get; set; }
    }
}
