using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BookingReviewCategory
{
    public int Id { get; set; }

    public int BookiingReviewId { get; set; }

    public string Category { get; set; } = null!;

    public int RateingValue { get; set; }
}
