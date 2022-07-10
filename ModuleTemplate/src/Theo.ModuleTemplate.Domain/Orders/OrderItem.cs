using System;
using Volo.Abp.Domain.Entities;

namespace Theo.ModuleTemplate.Orders;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; protected set; }
    public Guid ProductId { get; protected set; }
    public int Count { get; protected set; }
    protected OrderItem() { }

    internal OrderItem(Guid orderId, Guid productId, int count = 1)
    {
        OrderId = orderId;
        ProductId = productId;
        Count = count;
    }

    internal void ChangeCount(int newCount)
    {
        Count = newCount;
    }
    public override object[] GetKeys()
    {
        return new object[] { OrderId, ProductId };
    }

    public Order Order { get; set; }
}
