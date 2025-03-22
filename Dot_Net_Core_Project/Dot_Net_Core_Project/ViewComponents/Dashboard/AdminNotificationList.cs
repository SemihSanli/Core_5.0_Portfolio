using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.ViewComponents.Dashboard
{
    public class AdminNotificationList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
