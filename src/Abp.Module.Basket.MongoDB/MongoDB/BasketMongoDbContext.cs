using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Module.Basket.MongoDB
{
    [ConnectionStringName(BasketDbProperties.ConnectionStringName)]
    public class BasketMongoDbContext : AbpMongoDbContext, IBasketMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBasket();
        }
    }
}