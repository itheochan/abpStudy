using Microsoft.EntityFrameworkCore;
using Theo.ModuleTemplate.Customers;
using Theo.ModuleTemplate.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public class ModuleTemplateDbContext : AbpDbContext<ModuleTemplateDbContext>, IModuleTemplateDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; protected set; }
     */

    public DbSet<Customer> Customers { get; protected set; }

    public DbSet<Order> Orders { get; protected set; }
    public DbSet<OrderItem> OrderItems { get; protected set; }

    public ModuleTemplateDbContext(DbContextOptions<ModuleTemplateDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureModuleTemplate();
    }
}
