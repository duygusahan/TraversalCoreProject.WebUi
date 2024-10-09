using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.ViewComponents.UiLayoutComponents
{
    public class _UIScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
