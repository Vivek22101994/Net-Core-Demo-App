using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class SiteContent
{
    public int Id { get; set; }

    public string KeyName { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public string Value { get; set; } = null!;
}
