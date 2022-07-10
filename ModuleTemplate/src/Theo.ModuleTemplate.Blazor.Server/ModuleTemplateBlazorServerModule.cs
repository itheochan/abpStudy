using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ModuleTemplateBlazorModule)
    )]
public class ModuleTemplateBlazorServerModule : AbpModule
{

}
