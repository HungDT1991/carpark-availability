using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CarparkAvailability.Web.Pages
{
    public class IndexModel : CarparkAvailabilityPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}