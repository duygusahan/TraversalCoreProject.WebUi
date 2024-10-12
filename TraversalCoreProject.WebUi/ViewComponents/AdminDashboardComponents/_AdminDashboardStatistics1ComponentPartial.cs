using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.DataAccessLayer.Concrete;

namespace TraversalCoreProject.WebUi.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardStatistics1ComponentPartial:ViewComponent
    {
        TraversalContext context=new TraversalContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Users.Count();
            return View();
        }
    }
}
