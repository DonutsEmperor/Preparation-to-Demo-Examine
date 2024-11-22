using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class DishOrder
{
    public byte DishOrderId { get; set; }

    public byte OrderId { get; set; }

    public byte DishId { get; set; }

    public byte Quantity { get; set; }

    public byte StatusId { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
