using _7_razor_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_razor_view.Controllers
{
	public class HomeController : Controller
	{
		// Thực hành Razor View ở trang Index.cshtml
		public ActionResult Index()
		{
			return RedirectToAction("Razor2");
		}

		// Dùng Razor view xử lý bài toán tính tổng đơn giản
		public ActionResult Razor1()
		{
			return View();
		}

		//Thao tác với List và Dictionary 
		public ActionResult Razor2()
		{
			return View();
		}

		// Thao tác với try/catch
		public ActionResult	Razor3()
		{
			return View();
		}
	}
}