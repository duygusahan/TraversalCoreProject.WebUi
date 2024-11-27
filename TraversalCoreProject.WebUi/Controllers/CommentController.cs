using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            //ViewBag.destId = id;
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userId = value.Id; 
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {

            comment.Date = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            comment.Status = true;
            comment.UserName = "a";

            _commentService.TInsert(comment);
            return RedirectToAction("Index", "Destination");
        }
    }
}
