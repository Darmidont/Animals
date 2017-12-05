using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animal.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }



		


	    [HttpPost]
	    public ActionResult Logout()
	    {
		    Session.Clear();
		    return RedirectToAction("Index", "Home");

	    }


	}
}