using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.Controllers
{
    public class Contact : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index() 
        {
            var result = contactManager.GetAll();

            return View(result);
        }
        public IActionResult EnIndex()
        {
            var result = contactManager.GetAll();
            return View(result);
        }
    }
}
