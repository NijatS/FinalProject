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
	public class TextWhyConfiguration: IEntityTypeConfiguration<TextWhy>
	{
		public void Configure(EntityTypeBuilder<TextWhy> builder)
		{
			builder.Property(x => x.Title).IsRequired()
				.HasMaxLength(20);
			builder.Property(x => x.Text).IsRequired()
				.HasMaxLength(100);
			builder.Property(x => x.Icon).IsRequired();
			builder.Property(x => x.SettingId).IsRequired();
			builder.Property(x => x.CreatedAt)
			  .HasDefaultValue(DateTime.UtcNow.AddHours(4));
		}
	}
}
