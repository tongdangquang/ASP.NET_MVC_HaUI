using De2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De2.Controllers
{
	public class HomeController : Controller
	{	
		// start: 14h25p
		public ActionResult Cau1(SanPham s)
		{
			return View(s);
		}

		public ActionResult Cau2()
		{
			return View();
		}

		public ActionResult Ketqua(SanPham s)
		{
			return View(s);
		}
	}
}