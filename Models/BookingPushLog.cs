using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BookingPushLog
{
    public int Id { get; set; }

    public long ReservationId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime PushDateTime { get; set; }
}
