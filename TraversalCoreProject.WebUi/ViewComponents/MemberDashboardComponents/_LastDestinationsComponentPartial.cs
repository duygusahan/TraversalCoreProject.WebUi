using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.MemberDashboardComponents
{
    public class _LastDestinationsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinationsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_destinationService.TGetLast4Destination();
            return View(value);
        }
    }
}
