using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmenitiesChannelMap
{
    public int Id { get; set; }

    public int AmenityId { get; set; }

    public int ChanneId { get; set; }

    public int ListingId { get; set; }
}
