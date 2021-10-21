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
        public DbSet<Category> Categories { get; set; }

        public DbSet<Content> Contents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Server=(localdb)\\mssqllocaldb; Database=BlogDb_101821; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(ConnectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             
        }
    }   

}
