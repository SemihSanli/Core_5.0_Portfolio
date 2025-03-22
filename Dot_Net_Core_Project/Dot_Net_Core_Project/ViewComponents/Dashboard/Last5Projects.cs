using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.ViewComponents.Dashboard
{
    public class Last5Projects :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
         
            return View();
        }

    }
}
