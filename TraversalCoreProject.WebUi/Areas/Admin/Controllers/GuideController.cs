using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.BusinessLayer.ValidationRules;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var value = _guideService.TGetListAll();
            return View(value);
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _guideService.TChangeStatusToTrue(id);
            return RedirectToAction("Index" , "Guide" ,new {area="Admin"});
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            _guideService.TChangeStatusToFalse(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            guide.Status = true;
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result=validationRules.Validate(guide);
            if (result.IsValid) {
                _guideService.TInsert(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
           
        }
        public IActionResult DeleteGuide(int id)
        {
            _guideService.TDelete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
           var value= _guideService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            guide.Status = true;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
    }
}
