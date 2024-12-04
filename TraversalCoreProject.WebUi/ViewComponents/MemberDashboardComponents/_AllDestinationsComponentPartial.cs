using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.MemberDashboardComponents
{
    public class _AllDestinationsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _AllDestinationsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _destinationService.TGetListAll();
            return View(value);
        }
    }
}
