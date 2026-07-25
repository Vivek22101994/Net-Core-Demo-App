using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BookingMessage
{
    public int Id { get; set; }

    public string MessageId { get; set; } = null!;

    public string ConversionId { get; set; } = null!;

    public string? MessageContent { get; set; }

    public string? AttchemntUrl { get; set; }

    public string Sender { get; set; } = null!;

    public string ReservationId { get; set; } = null!;

    public int AgnetId { get; set; }

    public DateTime CreeatedDate { get; set; }
}
