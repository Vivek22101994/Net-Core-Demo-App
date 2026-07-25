using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Amenity
{
    public int AmenityId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }
}
