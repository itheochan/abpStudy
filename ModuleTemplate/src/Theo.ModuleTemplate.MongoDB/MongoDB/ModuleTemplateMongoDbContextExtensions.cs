using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Theo.ModuleTemplate.MongoDB;

public static class ModuleTemplateMongoDbContextExtensions
{
    public static void ConfigureModuleTemplate(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
