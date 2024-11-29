using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;

namespace TraversalCoreProject.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var value = _commentService.TGetCommentsWithDestination();
            return View(value);
        }

        public IActionResult CommentDetails(int id) 
        {
            var value = _commentService.TGetById(id);
            return View(value); 
        }

        public IActionResult DeleteComment(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });
           
        }
    }
}
