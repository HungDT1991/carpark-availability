using System;
using System.Collections.Generic;
using System.Text;
using CarparkAvailability.Localization;
using Volo.Abp.Application.Services;

namespace CarparkAvailability
{
    /* Inherit your application services from this class.
     */
    public abstract class CarparkAvailabilityAppService : ApplicationService
    {
        protected CarparkAvailabilityAppService()
        {
            LocalizationResource = typeof(CarparkAvailabilityResource);
        }
    }
}
