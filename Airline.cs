using System;
using System.Collections.Generic;

namespace test;

public partial class Airline
{
    public int AirlineId { get; set; }

    public string? NameAirline { get; set; }

    public string? Address { get; set; }

    public int? Rating { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
