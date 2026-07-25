using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class LocCityTb
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? PidCountry { get; set; }

    public int? IsActive { get; set; }
}
