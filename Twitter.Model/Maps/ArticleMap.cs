using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entites;

namespace Twitter.Model.Maps
{
    public class ArticleMap:CoreMap<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article");
            builder.Property(x => x.ArticleName).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.ArticleDescription).HasMaxLength(500).IsRequired(true);
            base.Configure(builder);
        }
    }
}
