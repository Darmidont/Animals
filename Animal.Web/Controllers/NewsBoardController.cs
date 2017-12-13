using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Common.Models.Bal;

namespace Animal.Web.Controllers
{
	public class NewsBoardController:Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult NewsBoardPage()
		{
			var model = new ParticularNewsModel();
			return View("NewsBoardPage", model);
		}


		[HttpPost]
		public ActionResult  AddNews()
		{



			return View("AddNewsPage");
		}
		//	public ActionResult

	}
}