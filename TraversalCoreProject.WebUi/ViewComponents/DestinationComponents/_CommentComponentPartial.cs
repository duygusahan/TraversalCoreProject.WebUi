using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.ViewComponents.DestinationComponents
{
    public class _CommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetDestinationById(id);

            return View(value);

        }
    }
}
