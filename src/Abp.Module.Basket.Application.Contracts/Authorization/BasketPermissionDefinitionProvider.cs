using Abp.Module.Basket.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Module.Basket.Authorization
{
    public class BasketPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(BasketPermissions.GroupName, L("Permission:Basket"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BasketResource>(name);
        }
    }
}