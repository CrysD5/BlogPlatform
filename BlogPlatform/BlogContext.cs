using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var ConnectionString = @"Server=(localdb)\mssqllocaldb; Database=BlogRestart; Trusted_Connection=True";

            builder.UseSqlServer(ConnectionString).UseLazyLoadingProxies();

            base.OnConfiguring(builder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Books"},
                new Category() { Id = 2, Name = "Music" },
                new Category() { Id = 3, Name = "Art" }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post() { Id = 1, Author = "Crys", Title = "Reading", Body = "I like it", CategoryId = 1, PublishDate = DateTime.Now},
                new Post() { Id = 2, Author = "Crys", Title = "Music", Body = "Is good", CategoryId = 2, PublishDate = DateTime.Now },
                new Post() { Id = 3, Author = "Crys", Title = "Painting", Body = "I do it" , CategoryId = 3, PublishDate = DateTime.Now }
                );

            base.OnModelCreating(modelBuilder);

        }

    }
}
