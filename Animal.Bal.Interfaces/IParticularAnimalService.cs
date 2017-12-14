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

		IEnumerable<AnimalParticularModel> GetParticularAnimalStats();

		void AddAnimalParticular(AnimalParticularModel animal);
		void DeleteAnimalParticular(AnimalParticularModel animal);
		void UpdateAnimalParticular(AnimalParticularModel animal);
	}
}
