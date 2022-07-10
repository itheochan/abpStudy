using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Theo.ModuleTemplate.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ModuleTemplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ModuleTemplate";
}
