using _6_file.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_file.Controllers
{
    public class read_write_fileController : Controller
    {
        // GET: read_write_file
        public ActionResult Index()
        {
            return View();
        }

		// 1. Lấy dữ liệu từ view bằng model và ghi vào file
		public ActionResult Save(SinhVien sv)
		{
			// Đường dẫn tới file lưu dữ liệu
			string path = Server.MapPath("~/Read_write_Files/student_info.txt");

			// Khai báo mảng kiểu xâu ký tự
			string[] line = { sv.id, sv.name, sv.marks.ToString() };

			// Ghi thông tin vào file
			System.IO.File.WriteAllLines(path, line);

			ViewBag.notify = "Lưu file thành công!";
			return View("Index"); // Trả về View Index
		}

		// 2. Đọc file và truyền dữ liệu sang view bằng ViewBag
		public ActionResult Open(SinhVien sv)
		{
			// Đường dẫn tới file lưu dữ liệu
			string path = Server.MapPath("~/Read_write_Files/student_info.txt");

			// Đọc file vào một mảng xâu lý tự
			string[] line = System.IO.File.ReadAllLines(path);

			// Gán dữ liệu cho đối tượng của model
			sv.id = line[0];
			sv.name = line[1];
			sv.marks = double.Parse(line[2]);

			ViewBag.info = $"{sv.id} - {sv.name} - {sv.marks}";
			ViewBag.notify = "Mở file thành công!";
			return View("Index");
		}
	}
}