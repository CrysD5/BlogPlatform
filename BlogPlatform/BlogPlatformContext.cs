using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogPlatformContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var ConnectionString = @"Server=(localdb)\mssqllocaldb; Database=Blog_102021; Trusted_Connection=True";

            builder.UseSqlServer(ConnectionString).UseLazyLoadingProxies();

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder options)
        {
            options.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Books" },
                new Category() { Id = 2, Name = "Music" },
                new Category() { Id = 3, Name = "Art" });


            base.OnModelCreating(options);
        }

    }
}
