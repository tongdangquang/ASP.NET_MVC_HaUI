using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De5.Models
{
	public class Nhanvien
	{
		public string manv { get; set; }
		public string hoten { get; set; }
		public string diachi { get; set; }
		public double songaylam { get; set; }
		public double luongngay { get; set; }
		public double tienluong
		{
			get
			{
				return songaylam * luongngay;
			}
		}
	}
}