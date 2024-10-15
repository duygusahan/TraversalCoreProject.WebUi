using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound404Page()
        {
            return View();
        }
    }
}
