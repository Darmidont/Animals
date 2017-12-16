using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;

namespace Animal.Web.Controllers
{
	public class AnimalParticularController : Controller
	{
		private readonly IParticularAnimalService _animalParticularService;
		private readonly IKindOfAnimalService _kindOfAnimalService;
		public AnimalParticularController(IParticularAnimalService animalParticularService, IKindOfAnimalService kindOfAnimalService)
		{
			_animalParticularService = animalParticularService;
			_kindOfAnimalService = kindOfAnimalService;
		}

		
		[HttpGet]
		public ActionResult GetAnimalParticularAddingView()
		{
			var model = new AnimalPaticularEditModel
			{
				AnimalTypes = _kindOfAnimalService.GetAnimalKinds().Select(_ => new SelectListItem()
				{
					 Text = _.Name,
					Value = _.Id.ToString()
				}).ToList()
			};

			return View("AddingNewParticularAnimal", model);
		}		

		[HttpPost]
		public ActionResult AddNewAnimalParticular(AnimalParticularModel model)
		{
			if (ModelState.IsValid)
			{
				_animalParticularService.AddAnimalParticular(model);

				//return View("DifferentAnimalsFromKindList");
				return RedirectToAction("GetByAnimalType", new {id = model.AnimalTypeId});
			}
			else
			{
				var m1 = new AnimalPaticularEditModel
				{
					AnimalTypes = _kindOfAnimalService.GetAnimalKinds().Select(_ => new SelectListItem()
					{
						Text = _.Name,
						Value = _.Id.ToString()
					}).ToList()
				};

				return View("AddingNewParticularAnimal", m1);
			}

		}

		[HttpGet]
		public ActionResult GetByAnimalType(int id)
		{
			var animals = _animalParticularService.GetParticularAnimalByKindId(id);
			return View("DifferentAnimalsFromKindList", animals);
		}

		[HttpPost]
		public ActionResult Update()
		{
			return View("UpdateAnimalsParticular");
		}

		[HttpPost]
		public ActionResult DeleteParticular(int id)
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