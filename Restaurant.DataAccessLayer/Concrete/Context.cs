using Microsoft.EntityFrameworkCore;
using Restaurant.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=DELL;Database=Restaurant;Trusted_Connection=True;TrustServerCertificate=True"));
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Booking> Bookings{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Discount> Discounts{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
    }
}
