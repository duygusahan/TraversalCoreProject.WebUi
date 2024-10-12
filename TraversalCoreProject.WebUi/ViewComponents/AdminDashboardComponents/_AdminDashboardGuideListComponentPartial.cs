using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardGuideListComponentPartial:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _AdminDashboardGuideListComponentPartial(IGuideService guideService)
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
