using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PmsamenitySubLevel
{
    public int Id { get; set; }

    public int AmenityMappingId { get; set; }

    public int? SubLevelField { get; set; }

    public int? SubLevelFieldValue { get; set; }
}
