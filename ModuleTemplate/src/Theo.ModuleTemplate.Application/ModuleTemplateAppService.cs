using Theo.ModuleTemplate.Localization;
using Volo.Abp.Application.Services;

namespace Theo.ModuleTemplate;

public abstract class ModuleTemplateAppService : ApplicationService
{
    protected ModuleTemplateAppService()
    {
        LocalizationResource = typeof(ModuleTemplateResource);
        ObjectMapperContext = typeof(ModuleTemplateApplicationModule);
    }
}
