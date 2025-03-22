using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
