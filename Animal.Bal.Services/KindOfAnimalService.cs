using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
namespace Animal.Bal.Services
{
	public class KindOfAnimalService : IKindOfAnimalService
	{
		public IEnumerable<AnimalKindEntity> GetAnimalKinds()
		{
			throw new NotImplementedException();
		}

		public void AddAnimalKind(AnimalKindModel animalKind)
		{
			throw new NotImplementedException();
		}


		public void UpdateAnimalKind(AnimalKindModel animalKind)
		{
			throw new NotImplementedException();
		}

		public void DeleteAnimalKind(AnimalKindModel animalKind)
		{
			throw new NotImplementedException();
		}
	}
}
