using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DestinationComponents
{
    public class _GuideDetailsComponentPartial:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetailsComponentPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _guideService.TGetById(2);
            return View(value);
        }
    }
}
