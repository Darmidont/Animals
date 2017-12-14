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


		public void AddOrUpdateAnimalKind(AnimalKindModel animalKind)
		{
			var animalKindEntity = Mapper.Map<AnimalKindEntity>(animalKind);
			if (animalKindEntity.Id == 0)
			{
				_animalKindRepository.Add(animalKindEntity);
			}
			else
			{
				_animalKindRepository.Update(animalKindEntity);
			}
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

		public AnimalKindModel GetAnimalKindById(int id)
		{
			return Mapper.Map<AnimalKindModel>(_animalKindRepository.GetById(id));
		}
	}
}