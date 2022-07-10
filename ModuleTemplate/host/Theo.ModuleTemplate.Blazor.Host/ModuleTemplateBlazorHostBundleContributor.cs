using Volo.Abp.Bundling;

namespace Theo.ModuleTemplate.Blazor.Host;

public class ModuleTemplateBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
