using ERPBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPBackend.Infrastructure.Configurations
{
    internal sealed class DepotConfiguration : IEntityTypeConfiguration<Depot>
    {
        public void Configure(EntityTypeBuilder<Depot> builder)
        {
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
