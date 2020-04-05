using Localization.Resources.AbpUi;
using Abp.Module.Basket.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(BasketApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BasketHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BasketHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BasketResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
