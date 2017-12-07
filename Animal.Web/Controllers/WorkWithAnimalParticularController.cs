using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;

namespace Animal.Web.Controllers
{
	public class WorkWithAnimalParticularController : Controller
	{
		private readonly IParticularAnimalService _animalParticularService;
		public WorkWithAnimalParticularController(IParticularAnimalService animalParticularService)
		{
			_animalParticularService = animalParticularService;
		}

		public ActionResult AddNewAnimal()
		{
			return View();
		}

	}
}