using Abp.Module.Basket.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Module.Basket
{
    public abstract class BasketAppService : ApplicationService
    {
        protected BasketAppService()
        {
            LocalizationResource = typeof(BasketResource);
            ObjectMapperContext = typeof(BasketApplicationModule);
        }
    }
}
