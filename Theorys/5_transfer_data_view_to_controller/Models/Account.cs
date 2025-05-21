using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_transfer_data_view_to_controller.Models
{
	public class Account
	{
		public string username { get; set; }
		public string password { get; set; }

		public List<Account> create_list_account()
		{
			List<Account> lst = new List<Account>();
			lst.Add(new Account() { username = "quangxd20", password = "123" });
			lst.Add(new Account() { username = "quangxd21", password = "123" });
			lst.Add(new Account() { username = "quangxd22", password = "123" });
			lst.Add(new Account() { username = "quangxd23", password = "123" });
			lst.Add(new Account() { username = "quangxd24", password = "123" });
			return lst;
		}
	}
}