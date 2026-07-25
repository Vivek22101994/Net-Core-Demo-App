using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntGathernRequestLog
{
    public Guid Uid { get; set; }

    public DateTime? LogDateTime { get; set; }

    public string? RequesUrl { get; set; }

    public string? RequestType { get; set; }

    public string? RequestContent { get; set; }

    public string? ResponseContent { get; set; }

    public string? RequestComments { get; set; }
}
