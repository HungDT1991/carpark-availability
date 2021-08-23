using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CarparkAvailability
{
    [Dependency(ReplaceServices = true)]
    public class CarparkAvailabilityBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CarparkAvailability";
    }
}
