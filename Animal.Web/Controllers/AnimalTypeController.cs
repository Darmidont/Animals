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

		// GET: WorkWithAnimal


		[HttpGet]
		public ActionResult GetAnimalKindView()
		{
			var models = _animalKindService.GetAnimalKinds();
			return View("DifferentKindsOfAnimalsList", models);
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
				_animalKindService.AddAnimalKind(model);
				return View("AddingNewKindOfAnimalCompleted");
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
			var animalKineds = _animalKindService.GetAnimalKinds();
			return View("DifferentKindsOfAnimalsList", animalKineds);
		}

		//	private AnimalParticularModel db = new AnimalParticularModel();
		public ActionResult ShowingListOfAnimalsFromKind()
		{
			//   var animals = db.CurrentNumberOfAnimals.ToList<AnimalParticularModel>().
			throw new NotImplementedException();
		}


	}
}