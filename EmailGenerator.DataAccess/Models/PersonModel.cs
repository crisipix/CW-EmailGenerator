using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public bool CanVote { get; set; }
        public string Email { get; set; }
    }
}
