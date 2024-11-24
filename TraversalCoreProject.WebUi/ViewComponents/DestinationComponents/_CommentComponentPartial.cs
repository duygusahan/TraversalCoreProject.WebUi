using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Concrete;

namespace TraversalCoreProject.WebUi.ViewComponents.DestinationComponents
{
    public class _CommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        TraversalContext context= new TraversalContext();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount=context.Comments.Where(x=>x.DestinationId==id).Count();    
            var value = _commentService.TGetCommentsWithDestinationAndUser(id); 

            return View(value);

        }
    }
}
