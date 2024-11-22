using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Category
{
    public byte CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
