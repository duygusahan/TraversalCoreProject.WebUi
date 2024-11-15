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
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<ResultAnnouncementDto>>(_announcementService.TGetListAll());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto addAnnouncementDto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TInsert(new Announcement()
                {
                    Content = addAnnouncementDto.Content,
                    Title = addAnnouncementDto.Title,
                    Date = DateTime.Now,
                });
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteAnnouncement(int id) 
        {
            _announcementService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values=_mapper.Map<UpdateAnnouncementDto>(_announcementService.TGetById(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto updateAnnouncementDto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementId = updateAnnouncementDto.AnnouncementId,
                    Content = updateAnnouncementDto.Content,
                    Title = updateAnnouncementDto.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
