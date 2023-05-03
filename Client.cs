using System;
using System.Collections.Generic;

namespace test;

public partial class Client
{
    public int ClientId { get; set; }

    public int? TourId { get; set; }

    public int? TripId { get; set; }

    public long? Passport { get; set; }

    public DateOnly? FirstDate { get; set; }

    public DateOnly? LastDate { get; set; }

    public virtual Tour? Tour { get; set; }

    public virtual Trip? Trip { get; set; }
}
