using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DefaultComponentPartial
{
    public class _DefaultSubAboutComponentPartial:ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _DefaultSubAboutComponentPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _subAboutService.TGetListAll();
            return View(value);
        }
    }
}
