using CarparkAvailability.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CarparkAvailability.Permissions
{
    public class CarparkAvailabilityPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CarparkAvailabilityPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(CarparkAvailabilityPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CarparkAvailabilityResource>(name);
        }
    }
}
