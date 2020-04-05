using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    [ConnectionStringName(BasketDbProperties.ConnectionStringName)]
    public interface IBasketDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}