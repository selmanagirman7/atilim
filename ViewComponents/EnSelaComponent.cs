using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class EnSelaComponent:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
