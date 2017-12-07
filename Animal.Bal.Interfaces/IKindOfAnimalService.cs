﻿using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
   public interface IKindOfAnimalService
	{
		IEnumerable<AnimalKindEntity> GetAnimalKinds();
		void AddAnimalKind(AnimalKindModel animalKind);
		void UpdateAnimalKind(AnimalKindModel animalKind);
		void DeleteAnimalKind(AnimalKindModel animalKind);

	}
}
