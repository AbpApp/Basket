using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Module.Basket.MongoDB
{
    public class BasketMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public BasketMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}