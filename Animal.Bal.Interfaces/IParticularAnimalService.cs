using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IParticularAnimalService
	{

		IEnumerable<AnimalParticularEntity> GetParticularAnimalStats();

		void AddAnimal(AnimalParticularModel animal);
		void DeleteAnimal(AnimalParticularModel animal);
		void ChangeAnimal(AnimalParticularModel animal);
		void AddAnimalParticular(AnimalParticularModel model);
	}
}
