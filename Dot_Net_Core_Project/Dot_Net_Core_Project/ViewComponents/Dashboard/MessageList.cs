using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
         
            return View();
        }
    }
}
