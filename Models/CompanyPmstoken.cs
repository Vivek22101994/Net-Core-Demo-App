using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class CompanyPmstoken
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ApiToken { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? Title { get; set; }
}
