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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.Vin)
                .IsUnicode()
                .HasMaxLength(17)
                .IsRequired();
            builder.Property(x => x.ModelId).IsRequired();
            builder.Property(x =>x.FabricationYear).
                IsRequired();
			builder.Property(x => x.Odometer).
		  IsRequired();
			builder.Property(x => x.FuelId).
		  IsRequired();
			builder.Property(x => x.NoGears).
		  IsRequired(); 
            builder.Property(x => x.Transmission).
				IsRequired(); 
            builder.Property(x => x.FuelCity).
				IsRequired();
			builder.Property(x => x.FuelWay).
				IsRequired(); 
            builder.Property(x => x.Motor).
				IsRequired();
			builder.Property(x => x.ColorId).
	             IsRequired();
			builder.Property(x => x.Price).
	             IsRequired();
			builder.Property(x => x.Description).
	             IsRequired();
			builder.Property(x => x.AppUserId).
                 IsRequired();
			builder.Property(x => x.BanId).
                 IsRequired();
			builder.Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
