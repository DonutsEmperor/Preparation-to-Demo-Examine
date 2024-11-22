using System;
using System.Collections.Generic;

namespace DemoExamVar4.Database.Models;

public partial class Employee
{
    public byte EmployeeId { get; set; }

    public string Suname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public byte RoleId { get; set; }

    public int Salary { get; set; }

    public byte UserId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
