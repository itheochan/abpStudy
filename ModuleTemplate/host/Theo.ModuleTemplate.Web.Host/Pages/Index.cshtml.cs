using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Theo.ModuleTemplate.Pages;

public class IndexModel : ModuleTemplatePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
