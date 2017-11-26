using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;

namespace Animal.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly IUserService _userService;

		public AccountController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public ActionResult GetRegistrationView()
		{
			var model = new UserModel();
			return View("GetRegistrationModel", model);
		}

		[HttpPost]
		public ActionResult Register(UserModel model)
		{
			if (ModelState.IsValid)
			{
				return View("RegistrationCompleted");
			}


			return View("GetRegistrationModel", model);
		}


		[HttpPost]

		public ActionResult GetAuthorizationView()
		{
			var model = new UserModel();
			return View("GetRegistrationModel", model);
		}


		[HttpPost]

		public ActionResult Authorization()
		{
			var model = new UserModel();
			return View("GetRegistrationModel", model);
		}
	}
}