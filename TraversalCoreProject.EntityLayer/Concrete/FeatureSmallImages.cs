using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class FeatureSmallImages
    {
        [Key]
        public int FeatureSmallImagesId { get; set; }
        public string SmallImageTitle { get; set; }
        public string SmallImageDescription { get; set; }
        public string SmallImageUrl { get; set; }
        public bool SmalImageStatus { get; set; }
    }
}
