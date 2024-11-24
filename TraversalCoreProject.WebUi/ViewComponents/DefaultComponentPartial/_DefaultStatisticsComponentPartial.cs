using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DefaultComponentPartial
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        private readonly IGuideService _guideService;
        private readonly IDestinationService _destinationService;
        private readonly IAppUserService _appUserService;

        public _DefaultStatisticsComponentPartial(IGuideService guideService, IDestinationService destinationService, IAppUserService appUserService)
        {
            _guideService = guideService;
            _destinationService = destinationService;
            _appUserService = appUserService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.V1=_guideService.TGetListAll().Count;
            ViewBag.V2=_destinationService.TGetListAll().Count;
            ViewBag.V3=_appUserService.TGetListAll().Count;
            return View();
        }
    }
}
