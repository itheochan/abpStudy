using System;
using System.Collections.Generic;
using System.Linq;
using Theo.ModuleTemplate.Enums;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Theo.ModuleTemplate.Orders;

public class Order : AggregateRoot<Guid>, ICreationAuditedObject
{
    public OrderStatus Status { get; set; }
    public DateTime OrderTime { get; set; }
    public DateTime PaymentTime { get; set; }
    public int TotalItemCount { get; protected set; }

    public ICollection<OrderItem> Items { get; set; }

    public Address DeliveryAddress { get; set; }
    public Address AlternateAddress { get; set; }
    public string Notes { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public void AddProduct(Guid productId, int count)
    {
        if (count <= 0)
        {
            throw new ArgumentException(
                "You can not add zero or negative count of products!",
                nameof(count)
            );
        }

        var existingLine = Items.FirstOrDefault(ol => ol.ProductId == productId);

        if (existingLine == null)
        {
            Items.Add(new OrderItem(this.Id, productId, count));
        }
        else
        {
            existingLine.ChangeCount(existingLine.Count + count);
        }

        TotalItemCount += count;
    }
}
