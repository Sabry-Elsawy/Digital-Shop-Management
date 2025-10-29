using Microsoft.AspNetCore.Mvc;

namespace WMS_DEPI_GRAD.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
