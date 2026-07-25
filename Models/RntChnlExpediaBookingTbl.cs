using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlExpediaBookingTbl
{
    public long Id { get; set; }

    public long? ReservationId { get; set; }

    public int HotelId { get; set; }

    public string RoomTypeId { get; set; } = null!;

    public string RatePlanId { get; set; } = null!;

    public string? Type { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? Source { get; set; }

    public string? Status { get; set; }

    public string? ConfirmNumber { get; set; }

    public string? SpecialRequests { get; set; }

    public string? SpecialRequestCodes { get; set; }
}
