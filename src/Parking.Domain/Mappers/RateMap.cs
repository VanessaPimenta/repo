using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class RateMap : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.ToTable("Rate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Descpription).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(x => x.DiaryValue).HasColumnType("float");
            builder.Property(x => x.OvernightValue).HasColumnType("float");
            builder.Property(x => x.FractionValue).HasColumnType("float");
        }
    }
}
