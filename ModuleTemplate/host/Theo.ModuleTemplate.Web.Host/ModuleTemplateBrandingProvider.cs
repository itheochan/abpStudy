using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Theo.ModuleTemplate;

[Dependency(ReplaceServices = true)]
public class ModuleTemplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ModuleTemplate";
}
