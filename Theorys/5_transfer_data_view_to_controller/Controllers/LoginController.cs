using _5_transfer_data_view_to_controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_transfer_data_view_to_controller.Controllers
{
    public class LoginController : Controller
    {
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Check(Account ac_input)
		{
			Account ac1 = new Account();
			List<Account> acc_lst = ac1.create_list_account();
			if (acc_lst.Any(ac => ac.username == ac_input.username && ac.password == ac_input.password))
				return RedirectToAction("HaUI");
			else
			{
				ViewBag.message = "Log in failed!";
				return View("Index");
			}
		}

		public ActionResult HaUI()
		{
			ViewBag.Message = "HaUI";
			return View();
		}

		public ActionResult CNTT()
		{
			ViewBag.Message = "CNTT";
			return View("HaUI");
		}

		public ActionResult HTTT()
		{
			ViewBag.Message = "HTTT";
			return View("HaUI");
		}

		public ActionResult KHMT()
		{
			ViewBag.Message = "KHMT";
			return View("HaUI");
		}

		public ActionResult KTPM()
		{
			ViewBag.Message = "KTPM";
			return View("HaUI");
		}
	}
}