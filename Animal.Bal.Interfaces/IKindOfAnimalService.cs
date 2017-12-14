using System.Collections.Generic;
using Animal.Common.Models.Bal;

namespace Animal.Bal.Interfaces
{
	public interface IKindOfAnimalService
	{
		IEnumerable<AnimalKindModel> GetAnimalKinds();
		void AddOrUpdateAnimalKind(AnimalKindModel animalKind);
		void DeleteAnimalKind(AnimalKindModel animalKind);
		AnimalKindModel GetAnimalKindById(int id);
	}
}