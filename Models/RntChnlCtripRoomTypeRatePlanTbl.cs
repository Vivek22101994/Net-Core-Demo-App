using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlCtripRoomTypeRatePlanTbl
{
    public string RoomTypeId { get; set; } = null!;

    public string RateCategory { get; set; } = null!;

    public string RatePlanCode { get; set; } = null!;

    public string? Name { get; set; }

    public int? Status { get; set; }

    public int? MaxOccupancy { get; set; }

    public int? MaxAdultOccupancy { get; set; }
}
