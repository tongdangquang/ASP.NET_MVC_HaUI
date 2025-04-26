using De5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De5.Controllers
{
	public class QuanlyNhanvienController : Controller
	{
		static List<Nhanvien> danhsach;
		public QuanlyNhanvienController()
		{
			danhsach = new List<Nhanvien>
			{
				new Nhanvien {manv = "Nv01", hoten = "Nguyễn Văn Anh", diachi = "Hà Nội", songaylam = 15, luongngay = 200000},
				new Nhanvien {manv = "Nv02", hoten = "Lê Thu Hà", diachi = "Hải Phòng", songaylam = 27, luongngay = 250000},
				new Nhanvien {manv = "Nv03", hoten = "Nguyễn Văn Hoàng", diachi = "Hà Nội", songaylam = 18, luongngay = 250000},
				new Nhanvien {manv = "Nv04", hoten = "Trần Thu Hương", diachi = "Hải Phòng", songaylam = 25, luongngay = 190000},
				new Nhanvien {manv = "Nv05", hoten = "Ngô Phương Thảo", diachi = "Quảng Ninh", songaylam = 20, luongngay = 18000}
			};
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult HienThi()
		{
			return View(danhsach);
		}

		public ActionResult NhapDuLieu()
		{
			return View();
		}

		[HttpPost]
		public ActionResult NhapDuLieu(Nhanvien nv)
		{
			danhsach.Add(nv);
			return View("TinhTienLuong", nv);
		}
	}
}