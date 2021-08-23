using Volo.Abp.Modularity;

namespace CarparkAvailability
{
    [DependsOn(
        typeof(CarparkAvailabilityApplicationModule),
        typeof(CarparkAvailabilityDomainTestModule)
        )]
    public class CarparkAvailabilityApplicationTestModule : AbpModule
    {

    }
}