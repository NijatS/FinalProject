using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Sliders
{
    public class SliderUpdateDto
    {
		public IFormFile? file { get; set; }
	}
}
