using Microsoft.AspNetCore.Mvc;

namespace WMS_DEPI_GRAD.Controllers
{
	public class WarehousesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult EditWarehouse()
		{
			return View();
		}
		public IActionResult WarehouseDetails()
		{
			return View();
		}
	}
}
