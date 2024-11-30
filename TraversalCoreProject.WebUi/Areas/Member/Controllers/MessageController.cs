﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.WebUi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
