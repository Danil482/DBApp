using System;
using System.Collections.Generic;

namespace test;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Password { get; set; }

    public int? BranchId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
