using EntityFrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                IsDeleted = false,
                Image = "blog-feature-img-1.jpg",
                Date = DateTime.Now,
                Title = "Blog-1",
                Description = "Description-1"
            },

            new Blog
            {
                Id = 2,
                IsDeleted = false,
                Image = "blog-feature-img-3.jpg",
                Date = DateTime.Now,
                Title = "Blog-2",
                Description = "Description-2"
            },

            new Blog
            {
                Id = 3,
                IsDeleted = false,
                Image = "blog-feature-img-4.jpg",
                Date = DateTime.Now,
                Title = "Blog-3",
                Description = "Description-3"
            });

            modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1,
                IsDeleted = false,
                Key = "HeaderLogo",
                Value = "logo.png"
            },

            new Setting
            {
                Id = 2,
                IsDeleted = false,  
                Key = "Phone",
                Value = "(055) 354-34-69"
            },

            new Setting
            {
                Id = 3,
                IsDeleted = false,
                Key = "ProductTake",
                Value = "4"
            },

            new Setting
            {
                Id = 4,
                IsDeleted = false,
                Key = "CompanyBoss",
                Value = "Bakhtiyar Shamilzada"
            });
        }
    }
}
