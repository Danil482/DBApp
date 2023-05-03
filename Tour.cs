using System;
using System.Collections.Generic;

namespace test;

public partial class Tour
{
    public int TourId { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public int? HotelId { get; set; }

    public decimal? Cost { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Hotel? Hotel { get; set; }
}
