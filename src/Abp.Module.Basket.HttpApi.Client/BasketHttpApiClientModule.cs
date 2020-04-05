using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(BasketApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BasketHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Basket";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BasketApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
