using System.Collections.Generic;
using Animal.Common.Models.Bal;

namespace Animal.Bal.Interfaces
{
	public interface IParticularAnimalService
	{
		IEnumerable<AnimalParticularModel> GetParticularAnimalStats();
		void AddAnimalParticular(AnimalParticularModel animal);
		void DeleteAnimalParticular(AnimalParticularModel animal);
		void UpdateAnimalParticular(AnimalParticularModel animal);
	}
}
