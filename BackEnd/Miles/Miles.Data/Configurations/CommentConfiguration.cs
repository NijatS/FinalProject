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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.AppUserId).IsRequired();
            builder.Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
