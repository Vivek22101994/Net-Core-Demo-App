using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RoomRatePlanMapping
{
    public int Id { get; set; }

    public string RoomId { get; set; } = null!;

    public string RatePlanId { get; set; } = null!;

    public int? MealPlanCode { get; set; }

    public string? ActiveDays { get; set; }

    public string? Policyname { get; set; }

    public int? WeekdayPricePer { get; set; }

    public int? IsReadOnlyRate { get; set; }
}
