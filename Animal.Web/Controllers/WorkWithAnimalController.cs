using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Data.Interfaces;

namespace Animal.Web.Controllers
{
    public class WorkWithAnimalController : Controller
    {
	    private IAnimalRepository repository;

	    public WorkWithAnimalController(IAnimalRepository repo)
	    {
		    repository = repo;
	    }

        // GET: WorkWithAnimal
        public ActionResult Index()
        {
            return View();
        }

	    public ActionResult DifferentKindsOfAnimalsList()
	    {
		    return View(repository.Animals);

	    }
    }
}