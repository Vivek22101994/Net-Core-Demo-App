using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlGathernEstateTbl
{
    public int MrId { get; set; }

    public string? GathernId { get; set; }

    public string? Status { get; set; }

    public DateTime? Date { get; set; }

    public string? Notes { get; set; }

    public string? SyncCategory { get; set; }

    public DateTime? SyncDtae { get; set; }
}
