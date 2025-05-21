using _7_razor_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_razor_view.Controllers
{
    public class HTML_HelperController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        // Tất cả các thẻ HTML helper quan trọng
        public ActionResult Theorys_of_HTML_helper()
        {
            return View();
        }

        // HTML helper tự sinh trong view 
        public ActionResult Regis(Student s)
        {
            var sub_lst = Request["subjects"];
            s.subjects = string.Join(", ", sub_lst);
            return View(s);
        }

        // Sử dụng Request để lấy URL cần thiết
        public ActionResult Call_URL()
        {
            return View();
        }
    }
}