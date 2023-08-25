using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Messages
{
    public class MessagePostDto
    {
		public string FirstName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? appUserId { get; set; }
		public string Text { get; set; }
	}
}
