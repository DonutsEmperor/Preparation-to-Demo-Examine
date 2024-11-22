using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Ingredient
{
    public byte IngredientId { get; set; }

    public string Name { get; set; } = null!;

    public int Volume { get; set; }

    public virtual ICollection<DishIngredient> DishIngredients { get; set; } = new List<DishIngredient>();
}
