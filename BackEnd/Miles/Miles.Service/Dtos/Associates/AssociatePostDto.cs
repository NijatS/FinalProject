using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Associates
{
    public class AssociatePostDto
    {
        public string Name { get; set; }
        public IFormFile file { get; set; }

    }
}
