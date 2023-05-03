using System;
using System.Collections.Generic;

namespace test;

public partial class Branch
{
    public int BranchId { get; set; }

    public string? Address { get; set; }

    public string? Postcode { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
