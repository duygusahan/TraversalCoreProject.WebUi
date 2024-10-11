using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.MemberDashboardComponents
{
    public class _GuideListComponentPartial:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideListComponentPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetListAll();
            return View(values);
        }
    }
}
