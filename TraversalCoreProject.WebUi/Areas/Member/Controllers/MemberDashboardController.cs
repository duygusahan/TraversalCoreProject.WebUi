using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
