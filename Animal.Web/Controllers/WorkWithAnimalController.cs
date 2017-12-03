using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Data.Interfaces;

namespace Animal.Web.Controllers
{
    public class WorkWithAnimalController : Controller
    {
		//  private IAnimalRepository repository;
	    private readonly IKindOfAnimalService _animalService;

		public WorkWithAnimalController(IAnimalParticularRepository repo)
	    {
		    repository = repo;
	    }

        // GET: WorkWithAnimal
        public ActionResult Index()
        {
            return View();
        }


	    [HttpPost]
	    public ActionResult AddNewKindOfAnimal(AnimalKindModel model)
	    {
		    if (ModelState.IsValid)
		    {
			    _animalService.AddNewKindOfAnimal(model);
			    return View("AddingNewTypeOfAnimalCompleted", );
		    }

		    return View("Registration", model);
	    }



	}
}