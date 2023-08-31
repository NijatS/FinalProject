using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class MilesAppDbContext : IdentityDbContext<AppUser>
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
		public DbSet<Setting> Settings { get; set; }
        public DbSet<TextWhy> TextWhies { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
		public DbSet<Social> Socials { get; set; }
		public DbSet<AboutText> AboutTexts { get; set; }
		public DbSet<AboutSkill> AboutSkills { get; set; }
		public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<Model> Models { get; set; }
		public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Auction> Auctions { get; set; }

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
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new TextWhyConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
			modelBuilder.ApplyConfiguration(new SocialConfiguration());
			modelBuilder.ApplyConfiguration(new AboutTextConfiguration());
			modelBuilder.ApplyConfiguration(new AboutSkillConfiguration());
			modelBuilder.ApplyConfiguration(new SubscribeConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new FuelConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ModelConfiguration());
			modelBuilder.ApplyConfiguration(new BanConfiguration());
			modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new CarImageConfiguration());
            modelBuilder.ApplyConfiguration(new BidConfiguration());
            modelBuilder.ApplyConfiguration(new AuctionConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
