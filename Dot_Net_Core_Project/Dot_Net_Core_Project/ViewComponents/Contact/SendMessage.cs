using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dot_Net_Core_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
      
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke()
        //{
          
        //}
    }
}
