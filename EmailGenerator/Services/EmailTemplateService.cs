using EmailGenerator.DataAccess.Models;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.Services
{
    /// <summary>
    /// http://mehdi.me/generating-html-emails-with-razorengine-basics-generating-your-first-email/
    /// </summary>
    public class EmailTemplateService : IEmailTemplateService
    {
        /// <summary>
        /// </summary>
        protected ITemplateService TemplateService { get; }

        /// <summary>
        /// </summary>
        /// <param name="templateService"></param>
        public EmailTemplateService(
            ITemplateService templateService
            )
        {
            TemplateService = templateService;
        }

        public string GenerateEmailBody() {
            // Create a model for our email
            var model = new PersonModel() { Name = "Sarah", Email = "sarah@mail.example", CanVote= false };
            var templateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"bin", "EmailTemplates");
            var templateFilePath = Path.Combine(templateFolderPath, "Email.cshtml");
            // Generate the email body from the template file.
            // 'templateFilePath' should contain the absolute path of your template file.
            //var TemplateService = new TemplateService();
            var emailHtmlBody = TemplateService.Parse(File.ReadAllText(templateFilePath), model, null, "Email");

            return emailHtmlBody;
        }
    }
}
