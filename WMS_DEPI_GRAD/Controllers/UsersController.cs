using Microsoft.AspNetCore.Mvc;

namespace WMS_DEPI_GRAD.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpdateUser()
        {
            return View();
        }
        public IActionResult UserDetails()
        {
            return View();
        }
    }
}
