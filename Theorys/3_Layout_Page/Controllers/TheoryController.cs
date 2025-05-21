using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_Layout_Page.Controllers
{
    public class TheoryController : Controller
    {
		public ActionResult Index()
		{
			ViewBag.Message = "HaUI";
			return View();
		}

		public ActionResult CNTT()
		{
			ViewBag.Message = "CNTT";
			return View();
		}

		public ActionResult HTTT()
		{
			ViewBag.Message = "HTTT";
			return View();
		}

		public ActionResult KHMT()
		{
			ViewBag.Message = "KHMT";
			return View();
		}

		public ActionResult KTPM()
		{
			ViewBag.Message = "KTPM";
			return View();
		}
	}
}