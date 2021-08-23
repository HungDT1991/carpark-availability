using System.Threading.Tasks;

namespace CarparkAvailability.Data
{
    public interface ICarparkAvailabilityDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
