using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Rateplan
{
    public int RatePlanId { get; set; }

    public Guid UniqueId { get; set; }

    public string Title { get; set; } = null!;

    public int? ParentRateplanId { get; set; }

    public int? MaxOcuupany { get; set; }

    public bool IsPrimary { get; set; }

    public string Currancy { get; set; } = null!;

    public string? SellMode { get; set; }

    public string? RateMode { get; set; }

    public int CompanyId { get; set; }
}
