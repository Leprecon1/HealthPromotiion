using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Food" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Motivation" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Training" });
            modelBuilder.Entity<Category>().HasData(new Category{ CategoryId = 4, CategoryName = "Science"} );
        }
    }
}
