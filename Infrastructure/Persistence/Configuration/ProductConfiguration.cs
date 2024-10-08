﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(a => a.Name)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(a => a.Description)
                .HasMaxLength(6969)
                .IsRequired();
        }
    }
}
