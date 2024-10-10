using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
