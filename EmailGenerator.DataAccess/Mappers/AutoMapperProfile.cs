using AutoMapper;
using EmailGenerator.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var personDoMapper = CreateMap<PersonModel, PersonDo>();
            var personMapper = CreateMap<PersonDo, PersonModel>();
            personMapper.ForMember(dest => dest.CanVote, opt => opt.ResolveUsing(src => src.Age >= 18));
            personMapper.ForMember(dest => dest.Email, opt => opt.ResolveUsing(src => $"{src.Name}@abc.com"));
        }
    }
}
