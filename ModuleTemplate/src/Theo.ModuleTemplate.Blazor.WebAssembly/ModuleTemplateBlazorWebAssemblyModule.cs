using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate.Blazor.WebAssembly;

[DependsOn(
    typeof(ModuleTemplateBlazorModule),
    typeof(ModuleTemplateHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ModuleTemplateBlazorWebAssemblyModule : AbpModule
{

}
