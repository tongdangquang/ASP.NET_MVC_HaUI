using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De3.Models
{
	public class NhanVien
	{
		public string manv { get; set; }
		public string hoten { get; set; }
		public string donvi { get; set; }
		public double luongngay { get; set; }
		public double songay { get; set; }
		public double thunhap
		{
			get
			{
				return (songay >= 25) ? (luongngay * songay + 500000) : (luongngay * songay);
			}
		}
	}
}