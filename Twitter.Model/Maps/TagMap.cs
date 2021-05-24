using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entites;

namespace Twitter.Model.Maps
{
    public class TagMap:CoreMap<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.Property(x => x.TagTitle).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.TagDescription).HasMaxLength(500).IsRequired(true);
            base.Configure(builder);
        }
    }
}
