using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.ViewComponents.UiLayoutComponents
{
    public class _UIFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
