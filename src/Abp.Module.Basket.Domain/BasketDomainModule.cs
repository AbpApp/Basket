using Volo.Abp.Modularity;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(BasketDomainSharedModule)
        )]
    public class BasketDomainModule : AbpModule
    {

    }
}
