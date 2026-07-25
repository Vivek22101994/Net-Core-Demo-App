using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GathrenCompanyMap
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public Guid Uuid { get; set; }

    public DateTime CreatedDate { get; set; }
}
