using System;
using System.Collections.Generic;

namespace MainApplication.Database.Models;

public partial class Order
{
    public byte OrderId { get; set; }

    public byte ClientId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Compound> Compounds { get; set; } = new List<Compound>();
}
