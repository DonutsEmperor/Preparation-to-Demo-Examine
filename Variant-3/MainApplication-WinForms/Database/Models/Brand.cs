using System;
using System.Collections.Generic;

namespace MainApplication.Database.Models;

public partial class Brand
{
    public byte BrandId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
