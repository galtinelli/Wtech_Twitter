using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Twitter.Core.Entities;
using Twitter.Model.Entites;
using Twitter.Model.Maps;

namespace Twitter.Model.Context
{
    public class TwitterContext:DbContext
    {
        public TwitterContext()
        {
        }
        
        //entityler bunlar diye tanıttık
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }

        //maplerin oluşturulması
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //map dosyalarımızı tetikliyoruz
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {   //değişiklikleri izle değişiklik varsa yada ekleme yapıldığında değiştir.
            var modifiedEntities = ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified || x.State == EntityState.Added)
                .ToList();
            return base.SaveChanges();
        }
    }
}
