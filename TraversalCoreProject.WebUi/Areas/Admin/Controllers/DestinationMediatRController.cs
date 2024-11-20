using MediatR;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetGuide(int id)
        {

            var values=await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);
        }
    }
}
