using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class CorporateComponent:ViewComponent
    {
        CorporateManager corporateManager = new CorporateManager(new EfCorporateDal());
        public IViewComponentResult Invoke()
        {
            var result = corporateManager.GetAll();
            return View(result);    
        }
    }
}
