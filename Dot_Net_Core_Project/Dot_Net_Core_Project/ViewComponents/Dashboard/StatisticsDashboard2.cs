using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Dot_Net_Core_Project.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 :ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2=c.Skills.Count();
            ViewBag.v3=c.Services.Count();
            return View();
        }
    }
}
