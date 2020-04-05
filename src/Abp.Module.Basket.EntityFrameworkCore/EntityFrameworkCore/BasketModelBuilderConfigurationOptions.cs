using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    public class BasketModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public BasketModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}