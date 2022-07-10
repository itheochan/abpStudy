using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Theo.ModuleTemplate.Orders;
using Volo.Abp.Domain.Entities;

namespace Theo.ModuleTemplate.Customers;

public class Customer : AggregateRoot<Guid>
{
    [StringLength(50)]
    public string UserName { get; set; }

    [StringLength(50)]
    public string NickName { get; set; }

    public DateTime Birthday { get; set; }

    [StringLength(10)]
    public string Gender { get; set; }

    [StringLength(50)]
    public string Email { get; set; }

    public ICollection<Address> DeliveryAddresses { get; set; }
}
