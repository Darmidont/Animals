using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.ClientServices.Providers;
using System.Web.Mvc;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
//using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNet.Identity.EntityFramework;

namespace Animal.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly IUserService _userService;
		//private readonly SignInManager<IdentityUser> _signInManager;

	//	 IClientFormsAuthenticationCredentialsProvider authProvider;

	//	public AccountController(IClientFormsAuthenticationCredentialsProvider auth)
	//	{
		//	authProvider = auth;
	//	}

	//	public ViewResult LogOnResult()
	//	{
	//		return View();
	//	}

	//	[HttpPost]
	//	public ActionResult LogOnResult(LogOnViewModel )




		public AccountController(IUserService userService)
		{
			_userService = userService;
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
				return View("RegistrationCompleted");
			}


			return View("Registration", model);
		}


		[HttpPost]

		public ActionResult GetAuthorizationView()
		{
			var model = new UserModel();
			return View("Authorization", model);
		}


		[HttpPost]

		public ActionResult Authorization()
		{
			var model = new UserModel();
			return View("Authorization", model);
		}






	//	[HttpPost]
		//public async Task<ActionResult> Logout()
		//{
			//await _signInManager.SignOutAsync();
	//		return RedirectToAction("Index", "Home");
	//	}
	}
}