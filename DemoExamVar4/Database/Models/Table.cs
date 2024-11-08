using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Table
{
    public byte TableId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
