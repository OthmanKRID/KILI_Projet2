using Microsoft.AspNetCore.Mvc;

namespace Kili.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
