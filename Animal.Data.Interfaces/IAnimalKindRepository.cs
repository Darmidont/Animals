using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IAnimalKindRepository
	{

		IEnumerable<AnimalKindEntity> GetAnimalTypes();
		IEnumerable<AnimalKindEntity> GetKindOfAnimalStats();

		void Add(AnimalKindEntity kind);
		void Update(AnimalKindEntity kind);
		void Delete(AnimalKindEntity kind);

	}
}