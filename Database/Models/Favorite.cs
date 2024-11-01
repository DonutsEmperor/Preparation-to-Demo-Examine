using System;
using System.Collections.Generic;

namespace DemoExam.Database.Models;

public partial class Favorite
{
    public byte FavoriteId { get; set; }

    public byte ClientId { get; set; }

    public byte? ProductId { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Product? Product { get; set; }
}
