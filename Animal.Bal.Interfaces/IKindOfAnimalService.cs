using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IKindOfAnimalService
	{
		IEnumerable<AnimalKindModel> GetAnimalKinds();
		void AddOrUpdateAnimalKind(AnimalKindModel animalKind);
		void DeleteAnimalKind(AnimalKindModel animalKind);
	}
}