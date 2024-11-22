using System;
using System.Collections.Generic;

namespace MainApplication.Database.Models;

public partial class Product
{
    public byte ProductId { get; set; }

    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte CategoryId { get; set; }

    public byte BrandId { get; set; }

    public byte AnimalId { get; set; }

    public string Description { get; set; } = null!;

    public string Compound { get; set; } = null!;

    public string Identity { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Compound> Compounds { get; set; } = new List<Compound>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
}
