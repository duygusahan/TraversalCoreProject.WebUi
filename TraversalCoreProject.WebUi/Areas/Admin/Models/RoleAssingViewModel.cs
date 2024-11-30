using DocumentFormat.OpenXml.Wordprocessing;

namespace TraversalCoreProject.WebUi.Areas.Admin.Models
{
    public class RoleAssingViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool RoleExist { get; set; }
    }
}
