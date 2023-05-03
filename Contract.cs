using System;
using System.Collections.Generic;

namespace test;

public partial class Contract
{
    public int ContractId { get; set; }

    public int? TourId { get; set; }

    public string? DepartureCountry { get; set; }

    public string? DepartureCity { get; set; }

    public int? ClientId { get; set; }

    public int? EmployeeId { get; set; }

    public float? TourCost { get; set; }

    public int? AirlineId { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Tour? Tour { get; set; }
}
