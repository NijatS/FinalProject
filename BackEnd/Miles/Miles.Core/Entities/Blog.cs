using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public string AuthorImage { get; set; }
        public string Image { get; set; }
        public string ImageUrl { get; set; }
        public List<BlogCategory>? BlogCategories { get; set; }
        public List<BlogTag>? BlogTags { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
