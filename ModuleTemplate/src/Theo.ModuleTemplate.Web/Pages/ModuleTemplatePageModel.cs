using Theo.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Theo.ModuleTemplate.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModuleTemplatePageModel : AbpPageModel
{
    protected ModuleTemplatePageModel()
    {
        LocalizationResourceType = typeof(ModuleTemplateResource);
        ObjectMapperContext = typeof(ModuleTemplateWebModule);
    }
}
