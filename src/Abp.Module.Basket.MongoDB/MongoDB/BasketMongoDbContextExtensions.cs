using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.Module.Basket.MongoDB
{
    public static class BasketMongoDbContextExtensions
    {
        public static void ConfigureBasket(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BasketMongoModelBuilderConfigurationOptions(
                BasketDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}