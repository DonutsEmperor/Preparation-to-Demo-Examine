using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Dish
{
    public byte DishId { get; set; }

    public string Name { get; set; } = null!;

    public string VolumeWeight { get; set; } = null!;

    public byte CategoryId { get; set; }

    public double Price { get; set; }

    public bool Availability { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<DishIngredient> DishIngredients { get; set; } = new List<DishIngredient>();

    public virtual ICollection<DishOrder> DishOrders { get; set; } = new List<DishOrder>();
}
