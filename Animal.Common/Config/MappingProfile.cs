using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using AutoMapper;
using AutoMapper.Configuration;

namespace Animal.Common.Config
{
	public class MappingProfile  : Profile
	{
		public MappingProfile()
		{
			//var modelMapperBuilder = builder ?? new MapperBuilder();
			var cfg = new MapperConfigurationExpression();
			cfg.CreateMap<UserModel, UserEntity>();
			cfg.CreateMap<UserEntity, UserModel>();
			cfg.CreateMap<AnimalKindEntity, AnimalKindModel>();
			cfg.CreateMap<AnimalKindModel, AnimalKindEntity>();
		}
	}
}
