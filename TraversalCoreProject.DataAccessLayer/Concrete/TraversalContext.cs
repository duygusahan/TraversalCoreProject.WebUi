using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.DataAccessLayer.Concrete
{
    public class TraversalContext:IdentityDbContext<AppUser , AppRole , int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-F4FLQJD ; initial Catalog=DbTraversal2; integrated Security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<FeatureBigImages> FeatureBigImages { get; set; }
        public DbSet<FeatureSmallImages> FeatureSmallImages { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
