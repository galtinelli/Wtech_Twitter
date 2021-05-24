using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entites;

namespace Twitter.Model.Maps
{
    public class CategoryMap:CoreMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.Property(x => x.CategoryName).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired(true);
            base.Configure(builder);
        }
    }
}
