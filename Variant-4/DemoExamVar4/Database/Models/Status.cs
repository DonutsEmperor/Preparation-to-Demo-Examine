using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DishOrder> DishOrders { get; set; } = new List<DishOrder>();
}
