using System;
using System.Collections.Generic;

namespace test;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int? AirlineId { get; set; }

    public int? TripId { get; set; }

    public string? Airport { get; set; }

    public string? NameTicket { get; set; }

    public DateOnly? DepartureDate { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual Trip? Trip { get; set; }
}
