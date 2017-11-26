using AutoMapper;
using EmailGenerator.DataAccess.Models;
using EmailGenerator.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private IPersonRepository      _repository;
        public PersonService(
            IMapper mapper,
            IPersonRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<PersonModel> GetPeople()
        {
            var people = _mapper.Map<IEnumerable<PersonDo>, IEnumerable<PersonModel>>(_repository.GetAll());
            return people;
        }

        public PersonModel GetPersonById(int id)
        {
            var person = _mapper.Map<PersonDo, PersonModel>(_repository.Get(id));
            return person;
        }

        


    }
}
