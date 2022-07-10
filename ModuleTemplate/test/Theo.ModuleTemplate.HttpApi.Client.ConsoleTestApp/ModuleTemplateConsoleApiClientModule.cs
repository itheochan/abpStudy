using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Theo.ModuleTemplate;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModuleTemplateHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ModuleTemplateConsoleApiClientModule : AbpModule
{

}
