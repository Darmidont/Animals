using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;

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

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}