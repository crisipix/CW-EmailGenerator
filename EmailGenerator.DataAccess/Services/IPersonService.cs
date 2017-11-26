using EmailGenerator.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Services
{
    public interface IPersonService
    {
        IEnumerable<PersonModel> GetPeople();
        PersonModel GetPersonById(int id);

    }
}
