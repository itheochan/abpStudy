using Theo.ModuleTemplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ModuleTemplateEntityFrameworkCoreTestModule)
    )]
public class ModuleTemplateDomainTestModule : AbpModule
{

}
