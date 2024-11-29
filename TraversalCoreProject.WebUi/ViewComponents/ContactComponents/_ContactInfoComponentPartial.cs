using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.ContactComponents
{
    public class _ContactInfoComponentPartial:ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactInfoComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value =_contactService.TGetContactInfo();
            return View(value);
        }
    }
}
