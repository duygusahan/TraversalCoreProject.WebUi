using MediatR;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.WebUi.CQRS.Commands.GuideComments;
using TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
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
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> AddGuide(CreateGuideCommands commands)
        {
            await _mediator.Send(commands);
            return RedirectToAction("Index", "GuideMediatR", new { area = "Admin" });
        }
    }
}
