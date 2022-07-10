using Localization.Resources.AbpUi;
using Theo.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Theo.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ModuleTemplateHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ModuleTemplateHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ModuleTemplateResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
