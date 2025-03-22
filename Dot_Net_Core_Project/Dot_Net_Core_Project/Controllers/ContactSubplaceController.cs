using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Core_Project.Controllers
{
    public class ContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());


        //public ActionResult Index()
        //{

        //}
        [HttpGet]
        public ActionResult EditSubContact()
        {

            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSubContact(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
