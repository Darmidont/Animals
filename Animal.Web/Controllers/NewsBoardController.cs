using System.Web.Mvc;
using Animal.Common.Models.Bal;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Data;

namespace Animal.Web.Controllers
{
	public class NewsBoardController:Controller
	{
		private readonly INewsService _newsService;
		public NewsBoardController(INewsService newsService)
		{
			_newsService = newsService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult GetNewsBoardPageView()
		{
			var model = _newsService.GetNews();
			return View("NewsBoardPage", model);
		}


		[HttpGet]
		public ActionResult GetAddNews()
		{
			var newsBoardEntity = new ParticularNewsIntoBoardEntity();
			return View("NewsBoardPage", newsBoardEntity);
		}



		[HttpPost]
		public ActionResult AddNews(ParticularNewsModel model)
		{
			if(ModelState.IsValid)
			{
				_newsService.AddNews(model);
				return View("NewsBoardPage");
			}
			else
			{
				return View("AddNews");
			}
		}
	}
}