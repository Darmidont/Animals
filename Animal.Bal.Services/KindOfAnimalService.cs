using System.Collections.Generic;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using AutoMapper;

namespace Animal.Bal.Services
{
	public class KindOfAnimalService : IKindOfAnimalService
	{
		private readonly IAnimalKindRepository _animalKindRepository;

		public KindOfAnimalService(IAnimalKindRepository animalKindRepository)
		{
			_animalKindRepository = animalKindRepository;
		}

		public IEnumerable<AnimalKindModel> GetAnimalKinds()
		{
			var animalDbTypes = _animalKindRepository.GetAnimalTypes();
			return Mapper.Map<IEnumerable<AnimalKindEntity>, IEnumerable<AnimalKindModel>>(animalDbTypes);
		}


		public void AddAnimalKind(AnimalKindModel animalKind)
		{
			var animalKindEntity = Mapper.Map<AnimalKindEntity>(animalKind);
			_animalKindRepository.Add(animalKindEntity);
		}


		public void UpdateAnimalKind(AnimalKindModel animalKind)
		{
			var animalKindEntity = Mapper.Map<AnimalKindEntity>(animalKind);
			_animalKindRepository.Update(animalKindEntity);

		}

		public void DeleteAnimalKind(AnimalKindModel animalKind)
		{
			var animalKindEntity = Mapper.Map<AnimalKindEntity>(animalKind);
			_animalKindRepository.Delete(animalKindEntity);

		}
	}
}