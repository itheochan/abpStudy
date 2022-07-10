using Microsoft.EntityFrameworkCore;
using SmartEnum.EFCore;
using System;
using Theo.ModuleTemplate.Customers;
using Theo.ModuleTemplate.Enums;
using Theo.ModuleTemplate.Orders;
using Volo.Abp;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

public static class ModuleTemplateDbContextModelCreatingExtensions
{
    public static void ConfigureModuleTemplate(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
        builder.ConfigureSmartEnum();
        //Configure all entities here. 

        builder.Entity<Customer>(customer =>
        {
            customer.OwnsMany(c => c.DeliveryAddresses, a =>
            {
                a.WithOwner().HasForeignKey("OwnerId");
                a.Property<Guid>("Id");
                a.HasKey("Id");
            });
        });

        builder.Entity<Order>(order =>
        {
            order.Property(o => o.Status).HasConversion(
                p => p.Value,
                p => OrderStatus.DeserializeValue(p));

            order.HasMany(e => e.Items).WithOne(i => i.Order).HasForeignKey(e => e.OrderId);

            /// OwnsOne
            order.OwnsOne(o => o.DeliveryAddress);
            /// OwnsOneString
            order.OwnsOne(typeof(Address), nameof(Order.AlternateAddress));

            /*
            /// ColumnNames
            order.OwnsOne(
                o => o.AlternateAddress,
                sa =>
                {
                    sa.Property(p => p.Street).HasColumnName("AlternateAddressToStreet");
                    sa.Property(p => p.CityId).HasColumnName("AlternateAddressToCityId");
                    sa.Property(p => p.Number).HasColumnName("AlternateAddressToCityNumber");
                });
            */
        });


    }
}
