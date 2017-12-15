using System;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Web.Controllers
{
	public class AnimalTypeController : Controller
	{
		private readonly IKindOfAnimalService _animalKindService;

		public AnimalTypeController(IKindOfAnimalService animalKindService)
		{
			_animalKindService = animalKindService;
		}

		[HttpGet]
		public ActionResult GetExistingAnimalKind()
		{
			var models = _animalKindService.GetAnimalKinds();
			return View("DifferentKindsOfAnimalsList", models);
		}

	//	[HttpGet]
	//	public ActionResult GetNewAnimalKind()
	//	{
	//		var animalKindEntity = new AnimalKindEntity();
		//	return View("DifferentKindsOfAnimalsList", animalKindEntity);
	//	}

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


		[HttpGet]
		public ActionResult GetAnimalKindAddingView()
		{
			var model = new AnimalKindModel();
			return View("AddingNewKindOfAnimal", model);
		}

		[HttpGet]
		public ActionResult ListOfKindsView()
		{
			var animalKinds = _animalKindService.GetAnimalKinds();
			return View("DifferentKindsOfAnimalsList", animalKinds);
		}

		[HttpGet]
		public ActionResult GetUpdateAnimalKind()
		{
			var animalKindEntity = new AnimalKindEntity();
			return View("UpdateInformationAboutKind", animalKindEntity);
		}
		

		//[HttpGet]
		//public ActionResult GetAnimalKind(int animalKindId)
		//{
		//	var model = _animalKindService.GetAnimalKindById(animalKindId);
		//	return View("AddingNewKindOfAnimal", model);
		//}



		[HttpPost]
		public ActionResult Delete(int animalKindId)
		{
			//_animalKindService.DeleteAnimalKind();
			return View("DifferentKindsOfAnimalsList");
		}

		[HttpPost]
		public ActionResult Update(int animalKind)
		{
			return View("UpdateInformationAboutKind");
		}
	}
}