using System;
using System.Collections.Generic;

namespace test;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? HotelAddress { get; set; }

    public string? NameHotel { get; set; }

    public int? Category { get; set; }

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
