using System;
using System.Collections.Generic;

namespace DemoExam.Database.Models;

public partial class Client
{
    public byte ClientId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte FavoriteId { get; set; }

    public virtual Favorite Favorite { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
