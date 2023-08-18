using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IEmailService
    {
        public Task SendMail(string from, string to, string subject, string text, string link, string name);
    }
}
