using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class OurServicesComponent:ViewComponent
    {
        OurServiceManager ourservicemanager = new OurServiceManager(new EfOurServiceDal());
        public IViewComponentResult Invoke()
        {
            var result = ourservicemanager.GetAll();
            return View(result);    
        }
    }
}
