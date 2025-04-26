using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De6.Models
{
	public class Hocsinh
	{
		public string mahs { get; set; }
		public string hoten { get; set; }
		public string gioitinh { get; set; }
		public string hoclop { get; set; }
		public double diem { get; set; }
		public string ketqua { get { return (diem > 5) ? "Đỗ" : "Trượt"; } }
	}
}