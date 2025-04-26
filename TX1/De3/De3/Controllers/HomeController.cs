using De3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De3.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Cau1()
		{
			return View();
		}

		public ActionResult Cau2()
		{
			return View();
		}
		public ActionResult Ketqua(NhanVien n)
		{
			return View(n);
		}
	}
}