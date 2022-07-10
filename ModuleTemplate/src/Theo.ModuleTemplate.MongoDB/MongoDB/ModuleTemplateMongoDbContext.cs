using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Theo.ModuleTemplate.MongoDB;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public class ModuleTemplateMongoDbContext : AbpMongoDbContext, IModuleTemplateMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureModuleTemplate();
    }
}
