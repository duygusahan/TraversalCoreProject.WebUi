using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardBannerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
