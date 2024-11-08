using System;
using System.Collections.Generic;

namespace DemoExam.Database.Models;

public partial class Animal
{
    public byte AnimalId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
