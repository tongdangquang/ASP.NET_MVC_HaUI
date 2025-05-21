using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Display()
		{
			//return PartialView("display"); // trả về 1 trang có thông tin
			//return Content("Hello world nhé!"); // trả về 1 nội dung bất kì mà không cần view()
			//return new EmptyResult(); // trả về 1 trang trống
			//return Redirect("https://vnexpress.net/"); // điều hướng đến một trang khác
			//return RedirectToAction("Index", "Hello"); // điều hướng đến 1 controller khác
			//return Json("hello wolrd 1 lần nữa", JsonRequestBehavior.AllowGet); // trả về 1 chuỗi json
			return new FilePathResult(@"D:\Documents\Kiem_thu_phan_mem_HaUI\NHOM16_2024IT6084007.pdf", "application/pdf"); // trả về 1 tập tin
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

		public ActionResult MyLink()
		{
			ViewBag.Message = "Liên kết của tôi";
			return View();
		}
	}
}