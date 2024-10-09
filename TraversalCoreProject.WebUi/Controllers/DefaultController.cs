using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
