﻿using System.Web;
using System.Web.Mvc;

namespace _9_LINQ
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
