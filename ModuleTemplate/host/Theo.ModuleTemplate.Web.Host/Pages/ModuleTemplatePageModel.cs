using Theo.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Theo.ModuleTemplate.Pages;

public abstract class ModuleTemplatePageModel : AbpPageModel
{
    protected ModuleTemplatePageModel()
    {
        LocalizationResourceType = typeof(ModuleTemplateResource);
    }
}
