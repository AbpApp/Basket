using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    public class BasketHttpApiHostMigrationsDbContext : AbpDbContext<BasketHttpApiHostMigrationsDbContext>
    {
        public BasketHttpApiHostMigrationsDbContext(DbContextOptions<BasketHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBasket();
        }
    }
}
