using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_file.Controllers
{
    public class UploadFileDemoController : Controller
    {
		// Upload ảnh và ảnh hiển thị ngay khi ấn Choose file
		public ActionResult InputImage()
		{
			return View();
		}

		[HttpPost]
		public ActionResult OutputImage(FormCollection fr)
		{
			var f = Request.Files["img1"]; // Lấy file từ input name="img1"
			string name = fr["name"];      // Lấy giá trị từ input name="name"
			string filename = System.IO.Path.GetFileName(f.FileName); // Lấy tên file (không kèm đường dẫn)

			string uploadPath = Server.MapPath("~/Images/") + filename;
			// Tạo đường dẫn tuyệt đối đến thư mục /Images/ trên server

			f.SaveAs(uploadPath); // Lưu file ảnh lên server

			// Truyền thông tin cho view để hiển thị lại
			ViewBag.name = name;
			ViewBag.imagename = filename;
			ViewBag.msg = "Upload Image is successfully";

			return View("InputImage"); // Quay lại view InputImage với các thông tin đã upload
		}
	}
}