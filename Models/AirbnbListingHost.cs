using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AirbnbListingHost
{
    public int Id { get; set; }

    public string ListingId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }
}
