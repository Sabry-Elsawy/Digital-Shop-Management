using Microsoft.AspNetCore.Mvc;

namespace WMS_DEPI_GRAD.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
