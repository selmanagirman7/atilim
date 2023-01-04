using Microsoft.AspNetCore.Mvc;

namespace Atilim.Controllers
{
    public class Catalog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnIndex()
        {
            return View();
        }
    }
}
