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
    public class UserPricingConfiguration :IEntityTypeConfiguration<UserPricing>
    {
        public void Configure(EntityTypeBuilder<UserPricing> builder)
        {
            builder.Property(x => x.Name).IsRequired()
               .IsUnicode()
                .HasMaxLength(30);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
