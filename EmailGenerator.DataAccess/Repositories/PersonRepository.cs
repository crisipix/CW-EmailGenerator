using EmailGenerator.DataAccess.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        //private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ILog _log;
        public PersonRepository(ILog log)
        {
            _log = log;
        }

        public IEnumerable<PersonDo> GetAll()
        {
            return new List<PersonDo> {
                new PersonDo { Name = "A", Age = 18},
                new PersonDo { Name = "B", Age = 22},
                new PersonDo { Name = "C", Age = 3},
                new PersonDo { Name = "D", Age = 28},
                new PersonDo { Name = "E", Age = 8}
            };
        }

        public PersonDo Get(int Id)
        {
            return new PersonDo();
        }

       
    }
}
