using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEmailRecipientLn
{
    public int PidRecipient { get; set; }

    public string PidLang { get; set; } = null!;

    public string? Title { get; set; }
}
