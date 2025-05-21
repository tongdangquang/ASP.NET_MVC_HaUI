using _5_transfer_data_view_to_controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_transfer_data_view_to_controller.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		// 1. Tham số, được cung cấp dưới 2 dạng:
		// Query String: tham số được truyền trực tiêp thông qua địa chỉ duyệt web (ví dụ: ~/index?name=quang&age=21), có truyền thông qua thẻ <a> trong html
		// Form field: tham số được lấy ra thông qua thẻ form (input, submit,...) trong html

		// 2. Trong MVC có 4 cách để controller nhận tham số từ view:
		// 2.1. Sử dụng đối tượng ngầm định Request
		// 2.2. Sử dụng tham số FormCollection
		// 2.3. Sử dụng Model
		// 2.4. Sử dụng đối số của Action


		// 2.1. Sử dụng đối tượng ngầm định Request
		public ActionResult Xuly1()
		{
			ViewBag.id = Request["id"];
			ViewBag.name = Request["name"];
			ViewBag.marks = double.Parse(Request["marks"]);
			return View();
		}

		// 2.2. Sử dụng tham số FormCollection (chỉ nhận các giá trị từ thẻ form)
		public ActionResult Xuly2(FormCollection fc)
		{
			ViewBag.id = fc["id"];
			ViewBag.name = fc["name"];
			ViewBag.marks = double.Parse(fc["marks"]);
			return View();
		}

		// 2.3. Sử dụng Model
		public ActionResult Xuly3(SinhVien sv)
		{
			// Có thể tạo một sv_model để lưu trữ tạm dữ liệu từ Index.cshtml rồi truyền cho Xuly3.cshtml hoặc không thì truyền trực tiếp sv vào Xuly3.cshtml luôn
			//SinhVien sv_model = new SinhVien();
			//sv_model.id = sv.id;
			//sv_model.name = sv.name;
			//sv_model.marks = sv.marks;
			return View(sv);
		}

		// 2.4. Sử dụng đối số của Action
		public ActionResult Xuly4(string id = "", string name = "", double marks = 0)
		{
			SinhVien sv = new SinhVien();
			sv.id = id;
			sv.name = name;
			sv.marks = marks;
			return View(sv);
		}
	}
}