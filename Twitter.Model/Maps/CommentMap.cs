using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entites;

namespace Twitter.Model.Maps
{
    public class CommentMap:CoreMap<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.Property(x => x.CommentTitle).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.CommentDescription).HasMaxLength(500).IsRequired(true);
            base.Configure(builder);
        }
    }
}
