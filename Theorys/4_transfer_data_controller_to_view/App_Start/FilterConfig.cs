using System.Web;
using System.Web.Mvc;

namespace _4_transfer_data_controller_to_view
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
