using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.ViewComponents.DefaultComponentPartial
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
