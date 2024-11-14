using ERPBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPBackend.Infrastructure.Configurations
{
    class RecipeDetailConfiguration : IEntityTypeConfiguration<RecipeDetail>
    {
        public void Configure(EntityTypeBuilder<RecipeDetail> builder)
        {
            builder.Property(x => x.Quantity).HasColumnType("decimal(5,2)");
        }
    }
}
