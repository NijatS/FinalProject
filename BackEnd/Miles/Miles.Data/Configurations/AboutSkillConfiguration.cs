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
    public class AboutSkillConfiguration :IEntityTypeConfiguration<AboutSkill>
    {
        public void Configure(EntityTypeBuilder<AboutSkill> builder)
        {
            builder.Property(x => x.Name).IsRequired()
                .IsUnicode()
                .HasMaxLength(40);
			builder.Property(x => x.Degree).IsRequired();
			builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
