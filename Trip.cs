using System;
using System.Collections.Generic;

namespace test;

public partial class Trip
{
    public int TripId { get; set; }

    public int? AirlineId { get; set; }

    public string? Airport { get; set; }

    public string? DestinationCountry { get; set; }

    public TimeOnly? DepartureTime { get; set; }

    public int? NumberOfSeats { get; set; }

    public string? DestinationCity { get; set; }

    public string? DepartureCountry { get; set; }

    public string? DepartureCity { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
