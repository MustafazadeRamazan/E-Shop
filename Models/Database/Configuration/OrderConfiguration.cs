using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop_srytr.Models.Entity;

namespace eshop_srytr.Models.Database.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(nameof(Order.DateTimeCreated))
                .HasDefaultValueSql("NOW(6)");
        }
    }
}
