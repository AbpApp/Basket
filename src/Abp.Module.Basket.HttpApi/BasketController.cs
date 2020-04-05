using Abp.Module.Basket.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Module.Basket
{
    public abstract class BasketController : AbpController
    {
        protected BasketController()
        {
            LocalizationResource = typeof(BasketResource);
        }
    }
}
