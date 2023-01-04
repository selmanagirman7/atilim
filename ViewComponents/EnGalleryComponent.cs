using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class EnGalleryComponent:ViewComponent
    {
        GaleryManager galerymanager = new GaleryManager(new EfGaleyDal());
        public IViewComponentResult Invoke()
        {
            var result = galerymanager.GetAll();
            return View(result);    
        }
    }
}
