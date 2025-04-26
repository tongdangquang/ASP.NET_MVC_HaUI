using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De2.Models
{
	public class SanPham
	{
		public string masp { get; set; }
		public string tensp { get; set; }
		public string loaisp { get; set; }
		public int soluong { get; set; }
		public double dongia { get; set; }
		public double thanhtien
		{
			get
			{
				if (soluong >= 200) return soluong * dongia * 0.85;
				else return soluong * dongia;
			}
		}
	}
}