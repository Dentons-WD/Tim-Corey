using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MoreInfo()
        {
            return View();
        }
    }
}
