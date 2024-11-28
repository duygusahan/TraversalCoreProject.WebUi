using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.DtoLayer.Dtos.ContactDtos;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        private readonly IContactService _contactService;

        public ContactController(IContactUsService contactUsService, IMapper mapper, IContactService contactService)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _contactService.TGetContactInfo();
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TInsert(new ContactUs()
                {
                    MessageBody=model.MessageBody,
                    Mail=model.Mail,
                    Name=model.Name,
                    Subject=model.Subject,
                    MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString())
             
                });
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
