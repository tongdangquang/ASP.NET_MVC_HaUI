using System.Web;
using System.Web.Mvc;

namespace _5_transfer_data_view_to_controller
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
