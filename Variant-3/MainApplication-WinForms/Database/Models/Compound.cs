using System;
using System.Collections.Generic;

namespace MainApplication.Database.Models;

public partial class Compound
{
    public byte CompoundId { get; set; }

    public byte OrderId { get; set; }

    public byte ProductId { get; set; }

    public byte Count { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
