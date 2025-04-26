using De1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Cau1(Hang h)
		{
			return View(h);
		}

		public ActionResult Cau2()
		{
			return View();
		}

		public ActionResult Ketqua(Hang h)
		{
			return View(h);
		}
	}
}