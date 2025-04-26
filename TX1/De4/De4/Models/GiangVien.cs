using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De4.Models
{
	public class GiangVien
	{
		public string magv {  get; set; }
		public string hoten {  get; set; }
		public string khoa {  get; set; }
		public double luonggio {  get; set; }
		public double sogio {  get; set; }
		public double luongthang
		{
			get
			{
				return (sogio < 120) ? luonggio * sogio : luonggio * sogio * 1.1;
			}
		}
	}
}