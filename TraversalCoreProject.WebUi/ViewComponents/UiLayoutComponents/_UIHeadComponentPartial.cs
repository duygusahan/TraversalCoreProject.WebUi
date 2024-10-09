using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.ViewComponents.UiLayoutComponents
{
    public class _UIHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
