using System;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;

//using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNet.Identity.EntityFramework;

namespace Animal.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly IAccountValidationService _accountValidationService;
		private readonly IUserService _userService;


		public AccountController(IUserService userService, IAccountValidationService accountValidationService)
		{
			_userService = userService;
			_accountValidationService = accountValidationService;
		}

		[HttpGet]
		public ActionResult GetRegistrationView()
		{
			var model = new UserModel();
			return View("Registration", model);
		}


		[HttpPost]
		public ActionResult Register(UserModel model)
		{
			if (ModelState.IsValid)
			{
				var isEmailAlreadyExists = _accountValidationService.IsEmailAlreadyExists(model.Email);
				if (isEmailAlreadyExists)
				{
					ModelState.AddModelError("Email", "Email already registered");
					return View("Registration", model);
				}
				_userService.AddUser(model);

				return View("RegistrationCompleted");
			}

			return View("Registration", model);
		}


		[HttpGet]
		public ActionResult GetAuthorizationView()
		{
			var model = new UserModel();
			return View("Authorization", model);
		}


		[HttpPost]
		public ActionResult Authorization()
		{
			var model = new UserModel();
			if (ModelState.IsValid)
				return View("AuthorizationCompleted");
			return View("Authorization", model);
		}


		[HttpPost]
		public ActionResult Logout()
		{
			Session.Clear();
			return RedirectToAction("Index", "Home");
		}


		[HttpPost]
		public ActionResult DeletingUser()
		{
			throw new NotImplementedException();
			//var model = 
			//return View("UserWasDeleted", model)
		}

		[HttpGet]
		public ActionResult OwnCab()
		{
			return View("OwnCab");
		}

		[HttpGet]
		public RedirectResult RedirectingToRegistration()
		{
			return Redirect("Registration");
		}
	}
}