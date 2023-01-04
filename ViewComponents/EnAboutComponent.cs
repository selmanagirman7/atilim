using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class EnAboutComponent:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var result = aboutManager.GetAll();
            return View(result);    
        }
    }
}
