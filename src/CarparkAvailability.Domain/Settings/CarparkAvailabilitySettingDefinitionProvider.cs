using Volo.Abp.Settings;

namespace CarparkAvailability.Settings
{
    public class CarparkAvailabilitySettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CarparkAvailabilitySettings.MySetting1));
        }
    }
}
