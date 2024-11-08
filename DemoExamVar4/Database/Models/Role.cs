using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Role
{
    public byte RoleId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
