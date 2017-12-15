using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IAnimalParticularRepository
	{

		IEnumerable<AnimalParticularEntity> GetAnimalsParticular();

		void Add(AnimalParticularEntity particular);
		void Update(AnimalParticularEntity particular);
		void Delete(AnimalParticularEntity particular);
		IEnumerable<AnimalParticularEntity> GetAnimalsbyAnimalKindId(int animalKindId);
	}
}
