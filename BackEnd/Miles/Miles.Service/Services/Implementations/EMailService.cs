using Microsoft.AspNetCore.Hosting;
using Miles.Core.Entities;
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
        public async Task SendCarMail(string from, string to, string subject, int bookId, string buyer, string date,Car car)
        {
            string body = string.Empty;
            string path = Path.Combine(_env.WebRootPath, "Templates", "carBuying.html");
            using (StreamReader SourceReader = System.IO.File.OpenText(path))
            {
                body = SourceReader.ReadToEnd();
            }
            body = body.Replace("{{User}}", buyer);
            body = body.Replace("{{Id}}",bookId.ToString());
            body = body.Replace("{{Date}}", date);
            body = body.Replace("{{CarName}}", car.Model.Brand.Name +" "+ car.Model.Name);
            body = body.Replace("{{CarId}}", car.Id.ToString());
            body = body.Replace("{{CarYear}}", car.FabricationYear.ToString());
            body = body.Replace("{{CarPrice}}", car.AuctionWinPrice.ToString());


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
        public async Task SendSubMail(string from, string to, string subject, Car car, AppUser appUser)
        {
            string body = string.Empty;
            string path = Path.Combine(_env.WebRootPath, "Templates", "subEmail.html");
            using (StreamReader SourceReader = System.IO.File.OpenText(path))
            {
                body = SourceReader.ReadToEnd();
            }
            body = body.Replace("{{Model}}", car.Model.Brand.Name + " "+car.Model.Name);
            body = body.Replace("{{Year}}", car.FabricationYear.ToString());
            body = body.Replace("{{Auction}}", car.ActionDate.ToString());
            body = body.Replace("{{Motor}}", car.Motor.ToString());
            body = body.Replace("{{CarId}}", car.Id.ToString());
            body = body.Replace("{{Owner}}", appUser.Name + " " + appUser.Surname);
            body = body.Replace("{{Price}}", car.Price.ToString());
            body = body.Replace("{{Email}}", appUser.Email);
            body = body.Replace("{{Country}}", appUser.Country.Name);

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
