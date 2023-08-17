﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Data.Configurations
{
    public class AboutTextConfiguration :IEntityTypeConfiguration<AboutText>
    {
        public void Configure(EntityTypeBuilder<AboutText> builder)
        {
            builder.Property(x => x.Title).IsRequired()
                .HasMaxLength(20);
			builder.Property(x => x.SubTitle).IsRequired()
				.HasMaxLength(20);
			builder.Property(x => x.Text).IsRequired()
				.HasMaxLength(200);
			builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
