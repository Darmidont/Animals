using System.Collections.Generic;
using Animal.Common.Models.Bal;

namespace Animal.Bal.Interfaces
{
	public interface IKindOfAnimalService
	{
		IEnumerable<AnimalKindModel> GetAnimalKinds();
		void AddAnimalKind(AnimalKindModel animalKind);
		void UpdateAnimalKind(AnimalKindModel animalKind);
		void DeleteAnimalKind(AnimalKindModel animalKind);
	}
}