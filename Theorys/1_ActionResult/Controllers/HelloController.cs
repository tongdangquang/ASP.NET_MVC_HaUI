using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
	public class HelloController : Controller
	{
		// GET: Hello
		public ActionResult Index()
		{
			return View();
		}
		//public string Index()
		//{
		//	return "Hello Index() method";
		//}
		public string Chaomung(string name = "Quang", int age = 3)
		{
			return "Hello " + name + "\nAge: " + age;
		}
	}
}