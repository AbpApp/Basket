using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Abp.Module.Basket.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Abp.Module.Basket
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class BasketDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BasketDomainSharedModule>("Abp.Module.Basket");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<BasketResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Basket");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Basket", typeof(BasketResource));
            });
        }
    }
}
