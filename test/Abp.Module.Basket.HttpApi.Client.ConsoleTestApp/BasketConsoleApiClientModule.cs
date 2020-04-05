using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(BasketHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BasketConsoleApiClientModule : AbpModule
    {
        
    }
}
