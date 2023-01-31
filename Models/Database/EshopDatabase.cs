using eshop_srytr.Models.Database.Configuration;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Entity;
using eshop_srytr.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eshop_srytr.Models.Database
{
    public class EshopDatabase : IdentityDbContext<User, Role, int>
    {
        public DbSet<CarouselItem> CarouselItems { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public EshopDatabase(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new OrderConfiguration());


            var entityTypes = builder.Model.GetEntityTypes();
            foreach (var entity in entityTypes)
            {
                entity.SetTableName(entity.GetTableName().Replace("AspNet", ""));
            }
        }
    }
}
