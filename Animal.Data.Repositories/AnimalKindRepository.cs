using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Animal.Data.Repositories
{
	public class AnimalKindRepository: Repository<AnimalKindEntity>, IAnimalKindRepository
	{
		public AnimalKindRepository([Dependency(Constants.AnimalDatabase)]Database database): base(database)
		{
		}

	}
}
