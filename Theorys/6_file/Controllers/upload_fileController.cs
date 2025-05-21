using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_file.Controllers
{
	public class upload_fileController : Controller
	{
		// GET: upload_file
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Upload()
		{
			return View();
		}

		// Dùng trang Index.cshtml để hiển thị giao diện upload file. Khi người dùng click "Upload" sẽ gọi đến action Upload() để xử lý và trả về kết quả
		[HttpPost]
		public ActionResult Upload(HttpPostedFileBase file)
		{
			try
			{
				if (file.ContentLength > 0) // Kiểm tra file hợp lệ
				{
					// Lấy tên file được chọn
					string _FileName = Path.GetFileName(file.FileName);

					// Ghép đường dẫn đầy đủ của file
					string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);

					// Lưu file vào thư mục UploadedFiles
					file.SaveAs(_path);

					ViewBag.Message = "File Uploaded Successfully!";
				}
			}
			catch
			{
				ViewBag.Message = "File Upload Failed!";
			}

			return View();
		}
	}
}