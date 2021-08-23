using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CarparkAvailability.Data
{
    /* This is used if database provider does't define
     * ICarparkAvailabilityDbSchemaMigrator implementation.
     */
    public class NullCarparkAvailabilityDbSchemaMigrator : ICarparkAvailabilityDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}