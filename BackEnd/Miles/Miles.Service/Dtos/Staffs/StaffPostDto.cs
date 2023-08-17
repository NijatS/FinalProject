using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Staffs
{
    public class StaffPostDto
    {
        public string FullName { get; set; }
        public string Info { get; set; }
        public int PositionId { get; set; }
        public IFormFile file { get; set; }
	}
}
