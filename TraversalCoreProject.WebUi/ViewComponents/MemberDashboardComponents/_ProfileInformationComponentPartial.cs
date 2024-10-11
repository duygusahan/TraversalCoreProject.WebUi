using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.ViewComponents.MemberDashboardComponents
{
    public class _ProfileInformationComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = value.Name + " " + value.Surname;
            ViewBag.memberPhone = value.PhoneNumber;
            ViewBag.memberMail = value.Email;
            return View();
        }
    }
}
