using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AirbnbAlter
{
    public int Id { get; set; }

    public string ConfirmationCode { get; set; } = null!;

    public long ListingId { get; set; }

    public string Status { get; set; } = null!;

    public long AlternationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Request { get; set; } = null!;
}
