using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entites;

namespace Twitter.Model.Maps
{
    public class UserMap:CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(500).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(500).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(500).IsRequired(true);
            builder.Property(x => x.Tag).HasMaxLength(500).IsRequired(true);

            base.Configure(builder);
        }
    }
}
