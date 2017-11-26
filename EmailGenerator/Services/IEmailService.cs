using EmailGenerator.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.Services
{
    public interface IEmailService
    {
        Task SendEmail(PersonModel person, string body);
    }
}
