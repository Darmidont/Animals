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
				_userService.AddUser(model);
				return View("RegistrationCompleted");
			}
			else
			{
				return View("Registration", model);
			}
			
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

		[HttpPost]
		public ActionResult Logout()
		{
			Session.Clear();
			return RedirectToAction("Index", "Home");

		}


		[HttpPost]
		public ActionResult DeletingUser()
		{
			throw  new NotImplementedException();
			//var model = 
			//return View("UserWasDeleted", model)
		}


		

	//	[HttpPost]
		//public async Task<ActionResult> Logout()
		//{
			//await _signInManager.SignOutAsync();
	//		return RedirectToAction("Index", "Home");
	//	}
	}
}