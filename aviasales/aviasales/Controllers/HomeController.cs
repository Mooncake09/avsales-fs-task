using Microsoft.AspNetCore.Mvc;

namespace aviasales.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
