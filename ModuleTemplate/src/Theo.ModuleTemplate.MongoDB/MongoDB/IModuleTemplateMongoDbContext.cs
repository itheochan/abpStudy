using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Theo.ModuleTemplate.MongoDB;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public interface IModuleTemplateMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
