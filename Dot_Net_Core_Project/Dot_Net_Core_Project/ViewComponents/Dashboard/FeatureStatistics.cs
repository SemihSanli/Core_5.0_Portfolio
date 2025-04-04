﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Dot_Net_Core_Project.ViewComponents.Dashboard
{
    public class FeatureStatistics :ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2= c.Messages.Where(x=>x.Status==false).Count();
            ViewBag.v2 = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4=c.Portfolios.Count();
            return View();
        }
    }
}
