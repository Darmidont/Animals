using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Common.Models.Bal;
using Animal.Bal.Interfaces;

namespace Animal.Web.Controllers
{
	public class NewsBoardController:Controller
	{

		private readonly IParticularNewsIntoBoardService _newsBoardService;
		public NewsBoardController(IParticularNewsIntoBoardService newsBoardService)
		{
			_newsBoardService = newsBoardService;
		}

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


		[HttpGet]
		public ActionResult  GetAddNews()
		{
			return View("NewsBoardPage");
		}

		[HttpPost]
		public ActionResult AddNews(ParticularNewsModel model)
		{
			if(ModelState.IsValid)
			{
				_newsBoardService.AddNews(model);
				return View("NewsBoardPage");
			}
			else
			{
				return View("AddNews");
			}
		}
	}
}