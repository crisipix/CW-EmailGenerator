using EmailGenerator.DataAccess.Models;
using log4net;
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
    /// 
    /// https://stackoverflow.com/questions/7027469/media-media-query-and-asp-net-mvc-razor-syntax-clash
    /// 
    /// https://github.com/TedGoas/Cerberus/blob/master/cerberus-fluid.html
    /// </summary>
    public class EmailTemplateService : IEmailTemplateService
    {
        /// <summary>
        /// </summary>
        protected ITemplateService TemplateService { get; }
        private readonly ILog _log;
     
        /// <summary>
        /// </summary>
        /// <param name="templateService"></param>
        public EmailTemplateService(
            ITemplateService templateService,
            
            ILog log)
        {
            TemplateService = templateService;
            
            _log = log;

        }

        public string GenerateEmailBody(PersonModel model) {
            // Create a model for our email
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
