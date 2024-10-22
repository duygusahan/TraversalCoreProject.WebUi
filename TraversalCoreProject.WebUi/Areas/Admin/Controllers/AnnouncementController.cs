using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.DtoLayer.Dtos.AnnouncementDtos;
using TraversalCoreProject.EntityLayer.Concrete;
using TraversalCoreProject.WebUi.Areas.Admin.Models;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
       
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetListAll();
            List<ResultAnnouncementViewModel> model = new List<ResultAnnouncementViewModel>();
            foreach(var item in announcements)
            {
                ResultAnnouncementViewModel result = new ResultAnnouncementViewModel();
                result.AnnouncementId= item.AnnouncementId;
                result.Title= item.Title;
                result.Content= item.Content;   
                model.Add(result);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult AddAnnouncement() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto addAnnouncementDto)
        {
            
            return View();
        }
    }
}
