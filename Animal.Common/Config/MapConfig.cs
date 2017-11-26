using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using AutoMapper.Configuration;

namespace Animal.Common.Config
{
	public class MapConfig
	{
		public static void Register()
		{
			//var modelMapperBuilder = builder ?? new MapperBuilder();
			var cfg = new MapperConfigurationExpression();
			cfg.CreateMap<UserEnity, UserModel>();

			
		}
	}
}
