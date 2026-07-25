using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AirbnbCompanyHost
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string HostId { get; set; } = null!;

    public int? ProjectId { get; set; }

    public int? IsOtherVerifed { get; set; }
}
