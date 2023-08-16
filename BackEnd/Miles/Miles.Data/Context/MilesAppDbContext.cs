using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Data.Context
{
    public class MilesAppDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
		public DbSet<Message> Messages { get; set; }
        public DbSet<UserPricing> UserPricings { get; set; }
        public DbSet<Feature> Features { get; set; }
		public DbSet<Associate> Associates { get; set; }
        public DbSet<Slider> Sliders { get; set; }


		public MilesAppDbContext(DbContextOptions<MilesAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
			modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new UserPricingConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureConfiguration());
			modelBuilder.ApplyConfiguration(new AssociateConfiguration());
			modelBuilder.ApplyConfiguration(new SliderConfiguration());
			base.OnModelCreating(modelBuilder);
        }
    }
}
