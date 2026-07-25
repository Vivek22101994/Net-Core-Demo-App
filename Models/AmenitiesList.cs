using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmenitiesList
{
    public int AmenityId { get; set; }

    public string Title { get; set; } = null!;

    public int ChanneId { get; set; }
}
