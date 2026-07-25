using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlHomeAwayEstateFeaturesRl
{
    public int PidEstate { get; set; }

    public string Type { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int? Count { get; set; }
}
