using Microsoft.EntityFrameworkCore;
using Theo.ModuleTemplate.Customers;
using Theo.ModuleTemplate.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public interface IModuleTemplateDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Customer> Customers { get; }
    DbSet<Order> Orders { get; }
    DbSet<OrderItem> OrderItems { get; }
}
