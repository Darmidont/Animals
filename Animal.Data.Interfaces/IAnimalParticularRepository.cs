using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IAnimalParticularRepository
	{
		IEnumerable<AnimalParticularEntity> GetAnimals(int animalKindId);
	}
}
