using CarparkAvailability.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CarparkAvailability
{
    [DependsOn(
        typeof(CarparkAvailabilityEntityFrameworkCoreTestModule)
        )]
    public class CarparkAvailabilityDomainTestModule : AbpModule
    {

    }
}