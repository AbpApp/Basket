using Volo.Abp.Reflection;

namespace Abp.Module.Basket.Authorization
{
    public class BasketPermissions
    {
        public const string GroupName = "Basket";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BasketPermissions));
        }
    }
}