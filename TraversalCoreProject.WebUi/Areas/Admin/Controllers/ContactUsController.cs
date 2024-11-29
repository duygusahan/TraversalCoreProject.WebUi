using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var value=_contactUsService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteMessage(int id)
        {
            _contactUsService.TDelete(id);
            return RedirectToAction("Index", "ContactUs", new { area = "Admin" });
        }
    }
}
