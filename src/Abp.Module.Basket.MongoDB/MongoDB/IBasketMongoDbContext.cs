using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Module.Basket.MongoDB
{
    [ConnectionStringName(BasketDbProperties.ConnectionStringName)]
    public interface IBasketMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
