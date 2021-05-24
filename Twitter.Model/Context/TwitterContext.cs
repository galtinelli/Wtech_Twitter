using System;
using Microsoft.EntityFrameworkCore;
using Twitter.Model.Entites;

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

            //burada UnitOfWork denilen bir design pattern var,
            //UnitOfWork, Db commit işlemlerini yönetiyor
            //bu pattern Generic Repository pattern ile birlikte çalışabilir

            string computerName = Environment.MachineName;
            string ipAddress = "127.0.0.1";
            DateTime date = DateTime.Now;

            foreach (var item in modifiedEntities)
            {
                CoreEntity entity = item.Entity as CoreEntity;
                if (item != null)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            entity.CreatedComputerName = computerName;
                            entity.CreatedIP = ipAddress;
                            entity.CreatedDate = date;
                            break;

                        case EntityState.Modified:
                            entity.ModifiedComputerName = computerName;
                            entity.ModifiedIP = ipAddress;
                            entity.ModifiedDate = date;
                            break;
                    }
                }

            }
            return base.SaveChanges();
        }
    }
}
