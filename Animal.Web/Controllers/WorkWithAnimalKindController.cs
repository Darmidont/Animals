using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Data.Interfaces;

namespace Animal.Web.Controllers
{
    public class WorkWithAnimalKindController : Controller
    {
	    private readonly IKindOfAnimalService _animalKindService;

		public WorkWithAnimalKindController(IKindOfAnimalService animalKindService)
	    {
			_animalKindService = animalKindService;
	    }

        // GET: WorkWithAnimal
   


	

   [HttpGet]
		public ActionResult GetAnimalKindView()
	    {
		    var model = new AnimalKindModel();
		    return View("DifferentKindsOfAnimalsList", model);
	    }



	    [HttpPost]
	    public ActionResult AddNewAnimalKind(AnimalKindModel model)
	    {
		    if (ModelState.IsValid)
		    {
			    _animalKindService.AddAnimalKind(model);
			    return View("AddingNewKindOfAnimalCompleted");
		    }
		    else
		    {
			    return View("AddingNewKindOfAnimal");
		    }

	    }



		//	private AnimalParticularModel db = new AnimalParticularModel();
		public ActionResult ShowingListOfAnimalsFromKind()
	    {
		 //   var animals = db.CurrentNumberOfAnimals.ToList<AnimalParticularModel>().
		 throw new NotImplementedException();
	    }

    }
}