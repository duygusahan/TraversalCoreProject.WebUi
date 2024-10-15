using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalCoreProject.WebUi.Models;

namespace TraversalCoreProject.WebUi.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Sayfasi Cagrildi");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy Sayfasi Cagrildi");
            return View();
        }

        public IActionResult Test() {
            _logger.LogInformation("Test Sayfasi Cagrildi");
            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
