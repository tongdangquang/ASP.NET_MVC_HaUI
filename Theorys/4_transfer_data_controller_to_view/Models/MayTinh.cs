using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4_transfer_data_controller_to_view.Models
{
	public class MayTinh
	{
		public string mamay { get; set; }
		public string dongmay { get; set; }
		public double giaban { get; set; }
		public DateTime ngaysx { get; set; }
		public string hangxs { get; set; }

		public List<MayTinh> list5may()
		{
			List<MayTinh> dsmay = new List<MayTinh>();

			dsmay.Add(new MayTinh()
			{
				mamay = "0000000001",
				dongmay = "Asus vivobook 15x",
				giaban = 18000000,
				ngaysx = new DateTime(2025, 1, 1),
				hangxs = "Asus"
			});
			dsmay.Add(new MayTinh()
			{
				mamay = "0000000002",
				dongmay = "Mac M1",
				giaban = 30000000,
				ngaysx = new DateTime(2025, 1, 2),
				hangxs = "Apple"
			});
			dsmay.Add(new MayTinh()
			{
				mamay = "0000000003",
				dongmay = "Thinkpad zenbook",
				giaban = 17000000,
				ngaysx = new DateTime(2025, 1, 3),
				hangxs = "Thinkpad"
			});
			dsmay.Add(new MayTinh()
			{
				mamay = "0000000004",
				dongmay = "Asus Rogtrix",
				giaban = 20000000,
				ngaysx = new DateTime(2025, 1, 4),
				hangxs = "Asus"
			});
			dsmay.Add(new MayTinh()
			{
				mamay = "0000000005",
				dongmay = "Acer Nitro",
				giaban = 10000000,
				ngaysx = new DateTime(2025, 1, 5),
				hangxs = "Acer"
			});

			return dsmay;
		}
	}
}