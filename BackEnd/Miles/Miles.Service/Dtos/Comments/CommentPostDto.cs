using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Comments
{
    public class CommentPostDto
    {
        public AppUser? AppUser { get; set; }
        public string? AppUserId { get; set; }
        public int? BlogId { get; set; }
        public int? CarID { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
