using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
      
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService userService, IReservationService reservationService)
        {
            _userService = userService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var value=_userService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteUser(int id) 
        {
            _userService.TDelete(id);
            return RedirectToAction("Index", "User", new { area = "Admin" });

        }

        [HttpGet]
        public IActionResult UpdateUser(int id) 
        {
            var value = _userService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser) 
        {
            _userService.TUpdate(appUser);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }

        //public IActionResult CommentUser(int id) 
        //{
        //    _userService.TGetListAll();
        //    return View();
        //}

        public IActionResult UserReservations(int id)
        {
           var value= _reservationService.TGetListWithReservationByAccepted(id);
            return View(value);
        }

       
    }
}
