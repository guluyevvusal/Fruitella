using Microsoft.AspNetCore.Mvc;

namespace Fruitella.PresentationLayer.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
