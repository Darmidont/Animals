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
			return View("AddingNewKindOfAnimal");
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
		

		[HttpGet]
		public ActionResult GetAnimalKind(int animalKindId)
		{
			var model = _animalKindService.GetAnimalKindById(animalKindId);
			return View("AddingNewKindOfAnimal", model);
		}

		//[HttpGet]
		//public ActionResult GetByType(int id)
		//{
		//	return View("AddingNewKindOfAnimal");
		//}


		//	public ActionResult Edit()
		//	{
		//		return View();
		//	}

		//	[HttpPost]
		//	public ActionResult Delete(int id = 0)
		//	{
		//AnimalKindModel _

		//	_animalKindService.DeleteAnimalKind
		//	if(_animalKindService == null)
		//	{
		//	return HttpNotFound();
		//}
		//	return View("DifferentKindsOfAnimalsList");
		//}
		//	private AnimalParticularModel db = new AnimalParticularModel();
		//	public ActionResult ShowingListOfAnimalsFromKind()
		//	{
		//   var animals = db.CurrentNumberOfAnimals.ToList<AnimalParticularModel>().
		//		throw new NotImplementedException();
		//	}





	}
}