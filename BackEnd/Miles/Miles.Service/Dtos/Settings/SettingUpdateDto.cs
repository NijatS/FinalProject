using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Settings
{
    public class SettingUpdateDto
    {
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public IFormFile? fileLogo { get; set; }
        public IFormFile? file { get; set; }
    }
}
