using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgodaRoomRatePlanMapping
{
    public int Id { get; set; }

    public string? RoomId { get; set; }

    public string? RatePlanId { get; set; }
}
