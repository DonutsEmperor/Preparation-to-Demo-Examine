using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class User
{
    public byte UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
