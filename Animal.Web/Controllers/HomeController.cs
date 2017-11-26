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
		private readonly ITestService _testService;
		public HomeController(ITestService testService)
		{
			_testService = testService;
		}
		public ActionResult Index()
		{
			var dd = _testService.Hello();
			var users = _testService.GetUsers();
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
			var users = _userService.GetUsers();
			return View("Index");
		}

		public ActionResult AddUser(UserEnity userEnity)
		{
			_userService.AddUser(userEnity);
			return View("Index");
		}

		public ActionResult AddUser()
		{
			return View();
		}


		public ActionResult GetParticularAnimalProperties(ParticularAnimalEnity particularAnimalEnity)
		{
			return View();
		}




		public ActionResult getKindOfAnimal(KindOfAnimalEnity kindOfAnimalEnity)
		{
			return View();
		}

		public ActionResult AboutUs()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		
	}
}