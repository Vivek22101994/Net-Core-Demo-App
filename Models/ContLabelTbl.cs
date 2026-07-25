using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ContLabelTbl
{
    public string Id { get; set; } = null!;

    public string PidLang { get; set; } = null!;

    public string? Type { get; set; }

    public string? Title { get; set; }
}
