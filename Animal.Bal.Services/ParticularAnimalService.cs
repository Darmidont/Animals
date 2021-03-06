﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using AutoMapper;
namespace Animal.Bal.Services
{
   public class ParticularAnimalService: IParticularAnimalService
	{

		private readonly IAnimalParticularRepository _animalParticularRepository;

		public ParticularAnimalService(IAnimalParticularRepository animalParticularRepository)
		{
			_animalParticularRepository = animalParticularRepository;
		}


		public IEnumerable<AnimalParticularModel> GetParticularAnimalStats()
		{
			var animalDbTypes = _animalParticularRepository.GetAnimalsParticular();
			return Mapper.Map<IEnumerable<AnimalParticularEntity>, IEnumerable<AnimalParticularModel>>(animalDbTypes);
		}

		public void AddAnimalParticular(AnimalParticularModel animalParticular)
		{
			var animalParticularEntity = Mapper.Map<AnimalParticularEntity>(animalParticular);
			_animalParticularRepository.Add(animalParticularEntity);
		}

		public void UpdateAnimalParticular(AnimalParticularModel animalParticular)
		{
			var animalParticularEntity = Mapper.Map<AnimalParticularEntity>(animalParticular);
			_animalParticularRepository.Update(animalParticularEntity);

		}

		public IEnumerable<AnimalParticularModel> GetParticularAnimalByKindId(int typeId)
		{
			return Mapper.Map<IEnumerable<AnimalParticularModel>>(_animalParticularRepository.GetAnimalsbyAnimalKindId(typeId));
		}

		public void DeleteAnimalParticular(AnimalParticularModel animalParticular)
		{
			var animalParticularEntity = Mapper.Map<AnimalParticularEntity>(animalParticular);
			_animalParticularRepository.Delete(animalParticularEntity);
		}

	}
}
