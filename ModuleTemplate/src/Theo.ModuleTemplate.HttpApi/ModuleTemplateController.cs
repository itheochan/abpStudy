using Theo.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Theo.ModuleTemplate;

public abstract class ModuleTemplateController : AbpControllerBase
{
    protected ModuleTemplateController()
    {
        LocalizationResource = typeof(ModuleTemplateResource);
    }
}
