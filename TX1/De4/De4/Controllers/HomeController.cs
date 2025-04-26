using De4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De4.Controllers
{
	// 11h55 => 12h55
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
		public ActionResult Ketqua(GiangVien gv)
		{
			return View(gv);
		}
	}
}