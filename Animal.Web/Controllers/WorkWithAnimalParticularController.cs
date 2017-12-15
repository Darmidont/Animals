using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;

namespace Animal.Web.Controllers
{
	public class WorkWithAnimalParticularController : Controller
	{
		private readonly IParticularAnimalService _animalParticularService;
		private readonly IKindOfAnimalService _kindOfAnimalService;
		public WorkWithAnimalParticularController(IParticularAnimalService animalParticularService, IKindOfAnimalService kindOfAnimalService)
		{
			_animalParticularService = animalParticularService;
			_kindOfAnimalService = kindOfAnimalService;
		}


/*
		[HttpGet]
		public ActionResult GetNewAnimalKind()
		{
			var animalKindEntity = new AnimalKindEntity();
			return View("DifferentKindsOfAnimalsList", animalKindEntity);
		}

		[HttpPost]
		public ActionResult AddNewAnimalKind(AnimalKindModel model)
		{
			if (ModelState.IsValid)
			{
				_animalKindService.AddOrUpdateAnimalKind(model);
				return View("DifferentKindsOfAnimalsList");
			}
			else
			{
				return View("AddingNewKindOfAnimal");
			}
		}
*/


		[HttpGet]
		public ActionResult GetAnimalParticularAddingView()
		{
			var model = new AnimalParticularModel();
			return View("AddingNewParticularAnimal", model);
		}



		[HttpGet]
		public ActionResult GetAnimalParticularView()
		{
			var model = new AnimalParticularModel();
			return View("DifferentParticularAnimalsList", model);
		}
		


		[HttpPost]
		public ActionResult AddNewAnimalParticular(AnimalParticularModel model)
		{
			if (ModelState.IsValid)
			{
				_animalParticularService.AddAnimalParticular(model);
				return View("DifferentAnimalsFromKindList");
			}
			else
			{
				return View("AddingNewParticularAnimal");
			}

		}


		[HttpGet]
		public ActionResult GetByAnimalType(int id)
		{
			var animals = _animalParticularService.GetParticularAnimalStats();
			return View("DifferentAnimalsFromKindList", animals);
		}

		[HttpPost]
		public ActionResult Update()
		{
			return View("UpdateAnimalsParticular");
		}

		[HttpPost]
		public ActionResult Delete()
		{
			return View("DifferentAnimalsFromKindList");
		}


		[HttpGet]
		public ActionResult UpdateInformationAboutAnimal()
		{
			return View("UpdateAnimalsParticular");
		}		
	}
}