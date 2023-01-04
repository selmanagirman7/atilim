using Microsoft.AspNetCore.Mvc;

namespace Atilim.ViewComponents
{
    public class SelaComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
