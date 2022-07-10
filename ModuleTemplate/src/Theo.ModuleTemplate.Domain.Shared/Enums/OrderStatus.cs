using Ardalis.SmartEnum;

namespace Theo.ModuleTemplate.Enums;

public class OrderStatus : SmartFlagEnum<OrderStatus>
{
    public static OrderStatus Created = new(nameof(Created), 0);
    public static OrderStatus PendingPayment = new(nameof(PendingPayment), 1);
    public static OrderStatus Paied = new(nameof(Paied), 2);
    public static OrderStatus PendingComfirm = new(nameof(PendingComfirm), 4);

    public OrderStatus() : this(Created.Name, Created.Value) { }
    public OrderStatus(string name, int value) : base(name, value)
    {
    }
}
