using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Animal.Common.Config
{
	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(x =>
			{
				x.AddProfile<MappingProfile>();
			});

			Mapper.Configuration.AssertConfigurationIsValid();
		}
	}
}
