using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class HomeAwayProjectPolicy
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string CancelPolicy { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public bool Ca { get; set; }

    public bool Pa { get; set; }

    public bool Ea { get; set; }

    public bool Sa { get; set; }

    public string AgrerementPath { get; set; } = null!;

    public string? AdvertiserAssignedId { get; set; }

    public decimal? ExchangeRate { get; set; }
}
