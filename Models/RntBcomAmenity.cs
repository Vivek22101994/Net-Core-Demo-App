using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntBcomAmenity
{
    public long Id { get; set; }

    public int AmenityCode { get; set; }

    public string? AmenityName { get; set; }

    public string? AmenityType { get; set; }

    public string? AmenityDescription { get; set; }

    public string? Category { get; set; }
}
