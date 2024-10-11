using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values=_destinationService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDestination(Destination destination)
        {
            _destinationService.TInsert(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
           
            _destinationService.TDelete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var value = _destinationService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DestinationDetails(int id)
        {
            var value = _destinationService.TGetById(id);
            return View(value);
        }
    }
}
