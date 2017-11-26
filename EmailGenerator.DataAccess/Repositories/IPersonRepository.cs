using EmailGenerator.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<PersonDo> GetAll();
        PersonDo Get(int Id);

    }
}
