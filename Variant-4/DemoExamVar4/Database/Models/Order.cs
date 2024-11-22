using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Order
{
    public byte OrderId { get; set; }

    public byte EmployeeId { get; set; }

    public byte TableId { get; set; }

    public virtual ICollection<DishOrder> DishOrders { get; set; } = new List<DishOrder>();

    public virtual Employee Employee { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;
}
