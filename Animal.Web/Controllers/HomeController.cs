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

		public ActionResult About()
		{
			return View("About");
		}
	}
}