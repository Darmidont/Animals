using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IAnimalKindRepository
	{
		IEnumerable<AnimalKindEntity> GetAnimalTypes();
	}
}