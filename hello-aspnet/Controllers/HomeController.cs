using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using hellomono.model;

namespace helloaspnet.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;
			ViewBag.Toto = "Toto";
			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}

		public ActionResult ListContacts()
		{
			var contacts = new List<Contact> ();
			while (contacts.Count < 10) 
			{
				contacts.Add (new Contact () { 
					FirstName = $"FirstName{contacts.Count}",
					LastName = $"LastName{contacts.Count}",
					EMail = $"FirstName{contacts.Count}.LastName{contacts.Count}@MailServer.COM"
				});
			}
			return View(contacts);
		}
	}
}

