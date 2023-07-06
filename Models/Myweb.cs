using System;
using Microsoft.EntityFrameworkCore;
namespace webapp
{
    public class MyWeb : DbContext
    {
        public MyWeb( DbContextOptions<MyWeb> options) : base(options)
        {
        }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
      

        public  DbSet<Article> articles {get;set;}
    }
}