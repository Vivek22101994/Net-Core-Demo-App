using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlHomeAwayLkFeatureValuesTbl
{
    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? SubType { get; set; }

    public string? Title { get; set; }

    public string? RefType { get; set; }

    public string? RefId { get; set; }
}
