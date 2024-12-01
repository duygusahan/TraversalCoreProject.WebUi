using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.BusinessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.EntityFramework;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
    public class ReservationController : Controller
    {
       private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.v=values.Id;
            var valuesList = _reservationService.TGetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }

        public async Task< IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.v=values.Id;
            var valuesList = _reservationService.TGetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.v=values.Id;
            var valuesList=_reservationService.TGetListWithReservationByApproveal(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text=x.TourName,
                                               Value=x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.Status = "Onay Bekliyor";
            p.AppUserId = 3;
            _reservationService.TInsert(p);
            return RedirectToAction("MyCurrentReservation" , "Reservation" , new { area = "Member" });
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
