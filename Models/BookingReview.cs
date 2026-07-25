using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BookingReview
{
    public int Id { get; set; }

    public string ReviewId { get; set; } = null!;

    public string ReservationCode { get; set; } = null!;

    public int? OverallRating { get; set; }

    public string? Cooment { get; set; }

    public string? Response { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ExprredDatetime { get; set; }
}
