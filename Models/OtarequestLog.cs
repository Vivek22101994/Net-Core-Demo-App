using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class OtarequestLog
{
    public int Id { get; set; }

    public int RoomTypeId { get; set; }

    public string Otaname { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int TotaUnit { get; set; }

    public bool Sucesss { get; set; }

    public string? Message { get; set; }

    public string? RequestPayload { get; set; }

    public DateTime AttemptDate { get; set; }

    public int? PmsrequestId { get; set; }

    public string? ListingId { get; set; }
}
