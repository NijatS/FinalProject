using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Blogs
{
    public class BlogUpdateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public IFormFile? file { get; set; }
        public IFormFile? fileAuthor { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> TagIds { get; set; }
		public List<BlogCategory>? BlogCategories { get; set; }
		public List<BlogTag>? BlogTags { get; set; }
	}
}
