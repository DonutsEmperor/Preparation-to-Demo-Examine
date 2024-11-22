using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class DishIngredient
{
    public short DishIngredientId { get; set; }

    public byte DishId { get; set; }

    public byte IngredientId { get; set; }

    public short Quanitity { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Ingredient Ingredient { get; set; } = null!;
}
