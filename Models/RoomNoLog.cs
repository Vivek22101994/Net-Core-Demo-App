using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RoomNoLog
{
    public int Id { get; set; }

    public long ReservationId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
