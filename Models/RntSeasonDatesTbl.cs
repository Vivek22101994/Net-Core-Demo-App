using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntSeasonDatesTbl
{
    public long Id { get; set; }

    public DateTime DtStart { get; set; }

    public DateTime DtEnd { get; set; }

    public string? Uid { get; set; }

    public DateTime? CreatedDate { get; set; }
}
