using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
	public class route_testController : Controller
	{
		// GET: route_test
		public ActionResult Index()
		{
			return View();
		}

		// truyền tham số vào ActionResult(trên thanh địa chỉ ở trình duyệt)
		public ActionResult TestPara(string msg, int number)
		{
			string str = "";
			for (int i = 0; i < number; i++)
				str += i + ". " + msg + "<br/>";
			return Content(str);
		}

		// sử dụng route để định tuyến tiện lợi hơn thay vì phải vào RouteConfig.cs để chỉnh sửa
		[Route("route_test/TestParav2/{msg=hello world}/{number=10}")]
		public ActionResult TestParav2(string msg, int number)
		{
			string str = "";
			for (int i = 0; i < number; i++)
				str += i + ". " + msg + "<br/>";
			return Content(str);
		}
	}
}