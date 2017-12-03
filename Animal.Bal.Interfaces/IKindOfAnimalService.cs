using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
   public interface IKindOfAnimalService
	{
		IEnumerable<AnimalKindEntity> GetAnimalKinds();
		void AddAnimalKind(AnimalKindModel animalKind);
		void ChangeAnimalKind(AnimalKindModel animalKind);
		void DeleteAnimalKind(AnimalKindModel animalKind);


	}
}
