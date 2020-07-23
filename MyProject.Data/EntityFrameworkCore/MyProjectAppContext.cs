using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyProject.Core.Entity;
using System;

namespace MyProject.Data.EntityFrameworkCore
{
    public class MyProjectAppContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProductQuantity> ProductQuantities { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<DiscountCode> DiscountCodes { get; set; }
        public DbSet<Product> Products { get; set; }

        public MyProjectAppContext(DbContextOptions<MyProjectAppContext> options) : base(options)
        {
        }
    }
}