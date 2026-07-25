using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ReservationAcknowledge
{
    public int Id { get; set; }

    public long ReservationId { get; set; }

    public bool Isacknowledge { get; set; }

    public DateTime AcknowledgeDatetime { get; set; }
}
