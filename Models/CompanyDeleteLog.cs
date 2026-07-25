using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class CompanyDeleteLog
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime DeletedDateTime { get; set; }
}
