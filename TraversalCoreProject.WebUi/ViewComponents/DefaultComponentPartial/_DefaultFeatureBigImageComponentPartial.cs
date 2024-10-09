using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DefaultComponentPartial
{
    public class _DefaultFeatureBigImageComponentPartial:ViewComponent
    {
        private readonly IFeatureBigImagesService _featureBigImagesService;

        public _DefaultFeatureBigImageComponentPartial(IFeatureBigImagesService featureBigImagesService)
        {
            _featureBigImagesService = featureBigImagesService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _featureBigImagesService.TGetListAll();
            return View(value);
        }
    }
}
