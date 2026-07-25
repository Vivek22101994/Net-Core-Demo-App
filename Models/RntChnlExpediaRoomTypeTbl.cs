using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlExpediaRoomTypeTbl
{
    public string Id { get; set; } = null!;

    public int HotelId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? SmokingPref { get; set; }

    public int? MaxOccupants { get; set; }
}
