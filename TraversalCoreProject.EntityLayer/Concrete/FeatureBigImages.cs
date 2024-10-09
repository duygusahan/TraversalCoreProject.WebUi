using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class FeatureBigImages
    {
        [Key]
        public int FeatureBigImagesId { get; set; }
        public string BigImageUrl { get; set; }
        public string BigImageTitle { get; set; }
        public string BigImageDescription { get; set; }
        public bool BigImageStatus { get; set; }
    }
}
