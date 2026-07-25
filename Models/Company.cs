using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int? ClientFilter { get; set; }
}
