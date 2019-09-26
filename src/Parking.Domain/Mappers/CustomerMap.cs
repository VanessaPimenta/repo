using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Document).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Address).HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(x => x.Phone).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Type).HasMaxLength(1).HasColumnType("varchar(1)");
        }
    }
}

