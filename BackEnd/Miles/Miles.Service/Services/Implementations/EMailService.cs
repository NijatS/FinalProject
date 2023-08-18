using Microsoft.AspNetCore.Hosting;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class EmailService:IEmailService
    {
        private readonly IWebHostEnvironment _env;

        public EmailService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public async Task SendMail(string from, string to, string subject, string text, string link, string name)
        {
            string body = string.Empty;
            string path = Path.Combine(_env.WebRootPath, "Templates", "email.html");
            using (StreamReader SourceReader = System.IO.File.OpenText(path))
            {
                body = SourceReader.ReadToEnd();
            }
            body = body.Replace("{{Link}}", link);
            body = body.Replace("{{Name}}", name);
            body = body.Replace("{{Text}}", text);
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = true;
            mm.From = new MailAddress(from);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential(from, "gmaagjxgczxovsrw");

            await smtp.SendMailAsync(mm);
        }
    }
}
