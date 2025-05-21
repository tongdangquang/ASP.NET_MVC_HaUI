using _4_transfer_data_controller_to_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_transfer_data_controller_to_view.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("Detail2");
		}

		// Cách 1. Dùng ViewBag hoặc ViewData[] để truyền dữ liệu từ controller sang view
		public ActionResult Detail()
		{
			// Dùng ViewBag
			ViewBag.id = "2022603783";
			ViewBag.name = "Tống Đăng Quang";
			ViewBag.marks = 3.42;

			// Dùng ViewData
			ViewData["major"] = "Information Systems";
			ViewData["school"] = "Hanoi University of Industry";

			return View();
		}

		// Cách 2. Dùng Model
		public ActionResult Detail2()
		{
			SinhVien sv = new SinhVien();
			sv.id = "2022603783";
			sv.name = "Tống Đăng Quang";
			sv.marks = 3.42;
			sv.major = "Information Systems";
			sv.school = "Hanoi University of Industry";
			return View(sv);
		}
	}
}