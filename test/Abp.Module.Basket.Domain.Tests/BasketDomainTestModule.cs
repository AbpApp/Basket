using Abp.Module.Basket.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Module.Basket
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(BasketEntityFrameworkCoreTestModule)
        )]
    public class BasketDomainTestModule : AbpModule
    {
        
    }
}
