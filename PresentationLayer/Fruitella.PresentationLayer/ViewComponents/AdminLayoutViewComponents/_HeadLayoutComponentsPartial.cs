




using Microsoft.AspNetCore.Mvc;

namespace Fruitella.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _HeadLayoutComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
