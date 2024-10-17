using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.WebUi.Models;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetListAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCity(TraversalCoreProject.EntityLayer.Concrete.Destination destination)
        {
            destination.Status = true;
            _destinationService.TInsert(destination);
            var values = JsonConvert.SerializeObject(destination);
            return View(values);
        }

        public IActionResult GetById(int id)
        {
            var value=_destinationService.TGetById(id);
            var jsonValues=JsonConvert.SerializeObject(value);
            return Json(jsonValues);
        }
    }
}
