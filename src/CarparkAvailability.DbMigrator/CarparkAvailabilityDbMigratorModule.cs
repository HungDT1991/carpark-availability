using CarparkAvailability.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CarparkAvailability.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CarparkAvailabilityEntityFrameworkCoreModule),
        typeof(CarparkAvailabilityApplicationContractsModule)
        )]
    public class CarparkAvailabilityDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
