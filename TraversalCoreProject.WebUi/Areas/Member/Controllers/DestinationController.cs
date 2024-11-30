using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.BusinessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.EntityFramework;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
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
    }
}
