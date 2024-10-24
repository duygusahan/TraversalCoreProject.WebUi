﻿using Microsoft.AspNetCore.Http;

namespace TraversalCoreProject.WebUi.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string name { get; set; }
        public string surname { get; set; }
        public string imageurl { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string confirmpassword { get; set; }
        public IFormFile  image { get; set; }
    }
}
