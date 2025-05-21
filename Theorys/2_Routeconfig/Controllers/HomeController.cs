using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		// truyền tham số vào actionresult
		public ActionResult Employee(int id)
		{
			return Content("<h1> id = " + id + "</h1>");
		}

		// truyền tham số có thể có hoặc không
		public ActionResult Demo1(int? pageindex, string sortby)
		{
			if (!pageindex.HasValue)
				pageindex = 1;
			if (string.IsNullOrWhiteSpace(sortby))
				sortby = "Name";
			return Content("PageIndex = " + pageindex + " - SortBy = " + sortby);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}