using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlAirbnbEstateStatusRl
{
    public long Id { get; set; }

    public int? PidEstate { get; set; }

    public string? AirbnbEstate { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public DateTime? Date { get; set; }
}
