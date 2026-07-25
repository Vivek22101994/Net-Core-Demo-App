using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AirbnbConfig
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public string? ClientSecrent { get; set; }

    public int CompanyId { get; set; }
}
