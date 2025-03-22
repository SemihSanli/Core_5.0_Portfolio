using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values =AboutManager.TGetList();
            return View(values);
        }
    }
}
