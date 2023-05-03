using System;
using System.Collections.Generic;

namespace test;

public partial class ClientTicketEmployee
{
    public int? ClientId { get; set; }

    public int? TicketId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Ticket? Ticket { get; set; }
}
