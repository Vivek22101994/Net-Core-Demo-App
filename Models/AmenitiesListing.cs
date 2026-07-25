using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmenitiesListing
{
    public int Id { get; set; }

    public int AmenityId { get; set; }

    public int ListingId { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public int? Category { get; set; }
}
