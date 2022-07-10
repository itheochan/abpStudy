using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModuleTemplateDomainSharedModule)
)]
public class ModuleTemplateDomainModule : AbpModule
{

}
