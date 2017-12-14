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
		public WorkWithAnimalParticularController(IParticularAnimalService animalParticularService)
		{
			_animalParticularService = animalParticularService;
		}


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
			return View("DifferentAnimalsFromKindList");
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
		



	
			
	//	public ActionResult AddNewAnimal()
	//	{
	//		return View();
	//	}

	}
}