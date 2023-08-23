using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Data.Configurations
{
    public class CarImageConfiguration :IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.Property(x => x.CarId).IsRequired();
			builder.Property(x => x.Image).IsRequired();
			builder.Property(x => x.ImageUrl).IsRequired();
			builder.Property(x => x.isMain).HasDefaultValue(false);
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
