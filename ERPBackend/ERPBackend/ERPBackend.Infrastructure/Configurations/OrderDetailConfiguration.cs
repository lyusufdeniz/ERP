﻿using ERPBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPBackend.Infrastructure.Configurations
{
    internal sealed class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(p => p.Product)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.Price).HasColumnType("money");
            builder.Property(p => p.Quantity).HasColumnType("decimal(7,2)");
        }
    }
}
