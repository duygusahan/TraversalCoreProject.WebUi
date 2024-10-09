using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DefaultComponentPartial
{
    public class _DefaultFeatureSmallImageComponentPartial:ViewComponent
    {
        private readonly IFeatureSmallImagesService _featureSmallImagesService;

        public _DefaultFeatureSmallImageComponentPartial(IFeatureSmallImagesService featureSmallImagesService)
        {
            _featureSmallImagesService = featureSmallImagesService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _featureSmallImagesService.TGetListAll();
            return View(value);
        }
    }
}
