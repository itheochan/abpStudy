using Theo.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Theo.ModuleTemplate.Blazor.Server.Host;

public abstract class ModuleTemplateComponentBase : AbpComponentBase
{
    protected ModuleTemplateComponentBase()
    {
        LocalizationResource = typeof(ModuleTemplateResource);
    }
}
