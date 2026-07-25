using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GoogleHotelRateplan
{
    public int Id { get; set; }

    public string RateplanId { get; set; } = null!;

    public string RateplanName { get; set; } = null!;

    public bool IsRefundable { get; set; }

    public int? RefundDay { get; set; }

    public string RefundTime { get; set; } = null!;

    public bool BreakfatIncude { get; set; }

    public string CheckInTime { get; set; } = null!;

    public string CheckOutTime { get; set; } = null!;

    public string? GoogleHotelId { get; set; }
}
