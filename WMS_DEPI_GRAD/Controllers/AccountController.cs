using Microsoft.AspNetCore.Mvc;

namespace WMS_DEPI_GRAD.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
