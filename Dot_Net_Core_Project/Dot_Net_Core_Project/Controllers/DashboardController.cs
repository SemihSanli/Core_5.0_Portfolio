using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
