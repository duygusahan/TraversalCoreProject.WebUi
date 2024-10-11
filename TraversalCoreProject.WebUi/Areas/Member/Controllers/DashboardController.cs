using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DashboardController : Controller
    {
       private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task< IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.username=values.Name + " " +values.Surname;
            ViewBag.userImage=values.ImageUrl;
            return View();
        }
    }
}
