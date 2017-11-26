using EmailGenerator.DataAccess.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILog _log;
        public EmailService(ILog log)
        {
            _log = log;
        }
        /// <summary>
        /// https://stackoverflow.com/questions/177974/how-can-i-make-email-go-to-a-local-folder-during-testing
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task SendEmail(PersonModel person, string body)
        {
         
            try
            {
                MailMessage mail = new MailMessage();
                var client = new SmtpClient();

                var emailPickupDirectory = client.PickupDirectoryLocation;

                if (emailPickupDirectory == null)
                {
                    throw new ApplicationException("Email Pickup Directory is null");
                }
                if (!Directory.Exists(emailPickupDirectory))
                {
                    Directory.CreateDirectory(emailPickupDirectory);
                }

                mail.From = new MailAddress("admin@abc.com");
                mail.To.Add(person.Email);
                mail.Subject = "Test Mail";
                mail.Body = body;
                mail.IsBodyHtml = true;

                client.Send(mail);
            }
            catch (Exception ex)
            {
                _log.Error("Failed to send email",ex);
            }

        }
    }
}
