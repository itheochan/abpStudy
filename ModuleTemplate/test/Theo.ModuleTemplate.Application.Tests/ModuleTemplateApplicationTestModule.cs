using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateApplicationModule),
    typeof(ModuleTemplateDomainTestModule)
    )]
public class ModuleTemplateApplicationTestModule : AbpModule
{

}
