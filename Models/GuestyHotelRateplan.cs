using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GuestyHotelRateplan
{
    public int Id { get; set; }

    public string GuestyId { get; set; } = null!;

    public string RatePlanId { get; set; } = null!;

    public string RatePlan { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? ParentRatePlan { get; set; }

    public int? PerVal { get; set; }
}
