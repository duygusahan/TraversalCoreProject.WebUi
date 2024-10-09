﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title1 { get; set; }
        public string Description1 { get; set; }
        public string Image1Url { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public bool Status { get; set; }
    }
}
