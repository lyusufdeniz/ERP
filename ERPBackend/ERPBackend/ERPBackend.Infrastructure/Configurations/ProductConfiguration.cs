using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPBackend.Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Type).HasConversion(type => type.Value,value=>ProductTypeEnum.FromValue(value));
        }
    }
}
