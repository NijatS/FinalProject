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
    public class StaffConfiguration :IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.Property(x => x.FullName).IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.Info).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.PositionId).IsRequired();
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
