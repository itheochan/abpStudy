using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

[DependsOn(
    typeof(ModuleTemplateDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ModuleTemplateEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        base.PreConfigureServices(context);
        ModuleTemplateDbContextEntityExtensionMappings.Configure();
    }
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ModuleTemplateDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
        });
    }
}
