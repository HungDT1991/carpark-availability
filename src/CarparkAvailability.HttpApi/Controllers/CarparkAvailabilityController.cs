using CarparkAvailability.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CarparkAvailability.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CarparkAvailabilityController : AbpController
    {
        protected CarparkAvailabilityController()
        {
            LocalizationResource = typeof(CarparkAvailabilityResource);
        }
    }
}