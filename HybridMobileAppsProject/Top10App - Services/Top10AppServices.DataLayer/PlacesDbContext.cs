using System;
using System.Data.Entity;
using System.Linq;
using Top10AppServices.Models;
using Top10AppServices.DataLayer.Mappings;

namespace Top10AppServices.DataLayer
{
    public class Top10AppDbContext : DbContext
    {                
        public Top10AppDbContext() : base("Top10AppDb")
        { 
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Subcategory> Subcategories { get; set; }
        public IDbSet<Story> Stories { get; set; }
        public IDbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new CategoryMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}