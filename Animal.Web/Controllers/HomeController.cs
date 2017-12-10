using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Data;

namespace Animal.Web.Controllers
{
	public class HomeController : Controller
	{		
	   public ActionResult Index()
		{
			return View();
		}

		public ActionResult UsersList()
		{
			
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Personal()
		{
			ViewBag.Message = "Your personal page.";

			return View();
		}


		public ActionResult Registration()
		{

			ViewBag.Message = "Hello! You can start using our service from this page!";

			return View();
		}

		public ActionResult Authorization()
		{
			ViewBag.Message = "You can authorize here:";
			return View();
		}

		public ActionResult Description()
		{
			ViewBag.Message = "Here you can find all descriptions about devices:";
			return View();
		}


		public ActionResult AnimalHusbandry()
		{
			//	var dd = _userService.Hello();
			return View("Index");
		}

		public ActionResult AddUser(UserEntity userEnity)
		{
			return View("Index");
		}

		public ActionResult AddUser()
		{
			return View();
		}


		public ActionResult GetParticularAnimalProperties(AnimalParticularEntity particularAnimalEnity)
		{
			return View();
		}

		public ActionResult getKindOfAnimal(AnimalKindEntity kindOfAnimalEnity)
		{
			return View();
		}

		public ActionResult AboutUs()
		{
			ViewBag.Message = "Your application description page.";

			return View("About");
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Personal information:";
			return View("Contact");
		}
		


	}
}