using _4_transfer_data_controller_to_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_transfer_data_controller_to_view.Controllers
{
    public class PracticeController : Controller
    {
		public ActionResult Index()
		{
			List<MayTinh> lst = new List<MayTinh>();
			return View(lst);
		}

		// Hiển thị 5 cái máy tính lên trang chủ (view)
		public ActionResult Display1()
		{
			MayTinh mt = new MayTinh();
			List<MayTinh> lst = mt.list5may();
			return View("Index", lst);
		}

		// Hiển thị 2 cái có giá thấp nhất (view)
		public ActionResult Display2()
		{
			MayTinh mt = new MayTinh();
			var lst = mt.list5may().OrderBy(m => m.giaban).Take(2);
			return View("Index", lst);
		}

		// Hiển thị sắp xếp từ giá cao đến thấp (view)
		public ActionResult Display3()
		{
			MayTinh mt = new MayTinh();
			var lst = mt.list5may().OrderByDescending(m => m.giaban);
			return View("Index", lst);
		}

		// Hiển thị các máy thuộc hãng Asus (view)
		public ActionResult Display4()
		{
			MayTinh mt = new MayTinh();
			var lst = mt.list5may().Where(m => m.hangxs == "Asus");
			return View("Index", lst);
		}
	}
}