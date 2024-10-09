using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
