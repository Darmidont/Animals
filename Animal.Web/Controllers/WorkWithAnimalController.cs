﻿using System;
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

	//	private Animal db = 
		//  private IAnimalRepository repository;
	    private readonly IKindOfAnimalService _animalService;

		public WorkWithAnimalController(IKindOfAnimalService animalService)
	    {
		    _animalService =animalService;
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
			    _animalService.Add(model);
			    return View("AddingNewTypeOfAnimalCompleted",);
		    }
		    else
		    {
			    return View("DifferentKindsOfAnimalsList", model);
		    }
	    }


	    [HttpPost]

	    public ActionResult AddNewAnimal(AnimalParticularModel model)
	    {
		    if (ModelState.IsValid)
		    {
			    _animalService.Add(model);
			    return View();
		    }
	    }

		private AnimalParticularModel db = new AnimalParticularModel();
	    public ActionResult ShowingListOfAnimalsFromKind()
	    {
		 //   var animals = db.CurrentNumberOfAnimals.ToList<AnimalParticularModel>().
		 throw new NotImplementedException();
	    }

    }
}