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
    public class BidConfiguration :IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.Property(x => x.AppUserId).IsRequired();
			builder.Property(x => x.CarId).IsRequired();
			builder.Property(x => x.Count).IsRequired();
			builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
