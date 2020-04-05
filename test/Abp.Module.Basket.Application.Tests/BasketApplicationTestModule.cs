using Volo.Abp.Modularity;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(BasketApplicationModule),
        typeof(BasketDomainTestModule)
        )]
    public class BasketApplicationTestModule : AbpModule
    {

    }
}
