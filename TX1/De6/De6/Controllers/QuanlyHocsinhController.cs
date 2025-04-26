using De6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De6.Controllers
{
	public class QuanlyHocsinhController : Controller
	{
		static List<Hocsinh> danhsach;


		public QuanlyHocsinhController()
		{
			danhsach = new List<Hocsinh>()
			{
				new Hocsinh { mahs = "hs01", hoten = "Học sinh 1", gioitinh = "Nam", hoclop = "10A", diem = 9 },
				new Hocsinh { mahs = "hs02", hoten = "Học sinh 2", gioitinh = "Nữ", hoclop = "10A", diem = 10 },
				new Hocsinh { mahs = "hs03", hoten = "Học sinh 3", gioitinh = "Nữ", hoclop = "10B", diem = 4 },
				new Hocsinh { mahs = "hs04", hoten = "Học sinh 4", gioitinh = "Nam", hoclop = "10B", diem = 8 },
				new Hocsinh { mahs = "hs05", hoten = "Học sinh 5", gioitinh = "Nam", hoclop = "10A", diem = 3 }
			};
		}

		public ActionResult Hienthi()
		{
			return View(danhsach);
		}

		public ActionResult Nhap()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Nhap(Hocsinh h)
		{
			danhsach.Add(h);
			return View("Xuat", h);
		}


	}
}