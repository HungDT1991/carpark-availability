using CarparkAvailability.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CarparkAvailability.Web.Pages
{
    public abstract class CarparkAvailabilityPageModel : AbpPageModel
    {
        protected CarparkAvailabilityPageModel()
        {
            LocalizationResourceType = typeof(CarparkAvailabilityResource);
        }
    }
}