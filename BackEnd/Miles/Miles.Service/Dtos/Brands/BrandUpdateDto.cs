using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Brands
{
    public class BrandUpdateDto
    {
		public string Name { get; set; }
		public IFormFile? file { get; set; }
	}
}
