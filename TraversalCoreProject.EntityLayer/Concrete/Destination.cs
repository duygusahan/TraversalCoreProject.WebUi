using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string TourName { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImageUrl { get; set; }
        public string MainDetails { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Image2 { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }
        public int? GuideId { get; set; }
        public Guide Guide { get; set; }
    }
}
