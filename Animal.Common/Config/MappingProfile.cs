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
			cfg.CreateMap<LoginModel, LoginEntity>();
			cfg.CreateMap<AnimalParticularModel, AnimalParticularEntity>();
			cfg.CreateMap<AnimalParticularEntity, AnimalParticularModel>();
		}
	}
}
