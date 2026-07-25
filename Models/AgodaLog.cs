using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgodaLog
{
    public Guid Uid { get; set; }

    public DateTime? LogDateTime { get; set; }

    public string? LogIp { get; set; }

    public string? LogUrl { get; set; }

    public string? ErrorType { get; set; }

    public string? ErrorContent { get; set; }
}
