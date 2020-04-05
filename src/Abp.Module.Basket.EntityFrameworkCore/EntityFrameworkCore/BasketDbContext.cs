using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    [ConnectionStringName(BasketDbProperties.ConnectionStringName)]
    public class BasketDbContext : AbpDbContext<BasketDbContext>, IBasketDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public BasketDbContext(DbContextOptions<BasketDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBasket();
        }
    }
}