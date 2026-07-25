using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntRequestTemplateLn
{
    public int PidTemplate { get; set; }

    public string PidLang { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }
}
